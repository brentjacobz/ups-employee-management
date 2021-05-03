using Serilog;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ServiceStack;
using UPS.EmployeeManagement.Services;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.UI
{
    public partial class EmployeeManagement : Form
    {
        private readonly IEmployeeService _employeeService;
        private EmployeeFilter _currentEmployeeFilter;
        private readonly ILogger _logger;
        private Employee _currentSelectedEmployee;

        public EmployeeManagement(ILogger logger)
        {
            InitializeComponent();
            _currentEmployeeFilter = new EmployeeFilter { PageNumber = 1 };
            _employeeService = ServiceFactory.CreateEmployeeService(logger, ConfigurationManager.AppSettings);
            _logger = logger;
            if (_employeeService == null)
            {
                lblFeedback.Text = "EmployeeService could not be created";
                Enabled = false;
            }
            else
            {
                lblFeedback.Text = "EmployeeService created successfully!";
            }
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // Load the first page of employees on startup
            PopulateEmployeeGrid();
            // Set all the Filter Controls
            ResetFilter();
        }

        private async void PopulateEmployeeGrid()
        {
            if (_employeeService == null)
                return;

            var employeeResponse = await _employeeService.GetEmployeesByPage(_currentEmployeeFilter);
            dgEmployees.DataSource = employeeResponse.Employees;
            // Update UI
            UpdateUI(employeeResponse.PageInformation);
        }

        private void UpdateUI(Pagination pagination)
        {
            if (pagination == null)
            {
                _logger.Warning("No pagination object return");
                return;
            }
            btnPrevious.Enabled = pagination.Page != 1;
            btnNext.Enabled = _currentEmployeeFilter.PageNumber != pagination.Pages;
            lblCurrentPage.Text = $"Page: {pagination.Page} of {pagination.Pages}";
        }

        private void ResetFilter()
        {
            txtFilterName.Text = "";
            txtFilterEmail.Text = "";
            ddlFilterGender.SelectedIndex = 0;
            ddlFilterStatus.SelectedIndex = 0;
        }

        private void UpdateSelectedEmployee()
        {
            if (dgEmployees.SelectedRows.Count == 0)
                return;

            _currentSelectedEmployee = dgEmployees.SelectedRows[0].DataBoundItem as Employee;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentEmployeeFilter.PageNumber--;
            PopulateEmployeeGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentEmployeeFilter.PageNumber++;
            PopulateEmployeeGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _currentEmployeeFilter.name = txtFilterName.Text;
            _currentEmployeeFilter.email = txtFilterEmail.Text;
            _currentEmployeeFilter.gender = ddlFilterGender.SelectedIndex > 0 ? ddlFilterGender.SelectedItem.ToString() : "";
            _currentEmployeeFilter.status = ddlFilterStatus.SelectedIndex > 0 ? ddlFilterStatus.SelectedItem.ToString() : "";

            PopulateEmployeeGrid();
        }

        private void dgEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedEmployee();
        }

        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // We can't delete anyone if we haven't selected anyone.
            if (_currentSelectedEmployee == null)
                return;

            var confirmResult = MessageBox.Show($"Do you want to remove {_currentSelectedEmployee.name}", "Delete Employee", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
                return;

            var crudEmployeeResponse = await _employeeService.DeleteEmployee(_currentSelectedEmployee.id);
            lblFeedback.Text = crudEmployeeResponse.ResponseMessage;
            PopulateEmployeeGrid();
        }

        private void dgEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UpdateSelectedEmployee();
        }

        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var upsertEmployee = new UpsertEmployee(null);
            var result = upsertEmployee.ShowDialog();
            if (result != DialogResult.OK)
                return;
            // Add the Employee
            var crudEmployeeResponse = await _employeeService.AddEmployee(upsertEmployee.Employee);
            lblFeedback.Text = crudEmployeeResponse.ResponseMessage;

            PopulateEmployeeGrid();
        }

        private async void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var upsertEmployee = new UpsertEmployee(_currentSelectedEmployee);
            var result = upsertEmployee.ShowDialog();
            if (result != DialogResult.OK)
                return;
            // Update the Employee
            // Add the Employee
            var crudEmployeeResponse = await _employeeService.UpdateEmployee(upsertEmployee.Employee);
            lblFeedback.Text = crudEmployeeResponse.ResponseMessage;
            
            PopulateEmployeeGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                FileName = "EmployeesExport",
                Filter = "Comma Delimited File|*.csv"
            };

            var employeesToExport = (from DataGridViewRow dataGridViewRow in dgEmployees.Rows select dataGridViewRow.DataBoundItem as Employee).ToList();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, employeesToExport.ToCsv());
            }
        }
    }
}

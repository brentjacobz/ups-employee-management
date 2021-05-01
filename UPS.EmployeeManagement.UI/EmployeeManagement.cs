using Serilog;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Serilog.Core;
using UPS.EmployeeManagement.Services;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Enums;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Providers;

namespace UPS.EmployeeManagement.UI
{
    public partial class EmployeeManagement : Form
    {
        private readonly IEmployeeService _employeeService;
        private int _currentPage;
        private string _currentSearch;
        private readonly ILogger Logger;
        private Employee _currentSelectedEmployee;

        public EmployeeManagement(ILogger logger)
        {
            InitializeComponent();
            _currentPage = 1;
            _employeeService = new EmployeeService(logger, ConfigurationManager.AppSettings);
            Logger = logger;
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // Load the first page of employees on startup
            PopulateEmployeeGrid();
        }

        private async void PopulateEmployeeGrid()
        {
            var employeeResponse = await _employeeService.GetEmployeesByPage(_currentPage, _currentSearch);
            dgEmployees.DataSource = employeeResponse.Employees;
            // Update UI
            UpdateUI(employeeResponse.PageInformation);
        }

        private void UpdateUI(Pagination pagination)
        {
            if (pagination == null)
            {
                Logger.Warning("No pagination object return");
                return;
            }
            btnPrevious.Enabled = pagination.Page != 1;
            btnNext.Enabled = _currentPage != pagination.Pages;
            lblCurrentPage.Text = $"Page: {pagination.Page} of {pagination.Pages}";
        }

        private void UpdateSelectedEmployee()
        {
            if (dgEmployees.SelectedRows.Count == 0)
                return;

            _currentSelectedEmployee = dgEmployees.SelectedRows[0].DataBoundItem as Employee;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            PopulateEmployeeGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            PopulateEmployeeGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _currentSearch = txtSearch.Text;
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

            await _employeeService.DeleteEmployee(_currentSelectedEmployee.id);
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
            await _employeeService.AddEmployee(upsertEmployee.Employee);
            PopulateEmployeeGrid();
        }

        private async void btnEditEmployee_Click(object sender, EventArgs e)
        {
            var upsertEmployee = new UpsertEmployee(_currentSelectedEmployee);
            var result = upsertEmployee.ShowDialog();
            if (result != DialogResult.OK)
                return;
            // Update the Employee
            await _employeeService.UpdateEmployee(upsertEmployee.Employee);
            PopulateEmployeeGrid();
        }
    }
}

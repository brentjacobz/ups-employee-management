using Serilog;
using System;
using System.Configuration;
using System.Windows.Forms;
using Serilog.Core;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;
using UPS.EmployeeManagement.Services.Providers;

namespace UPS.EmployeeManagement.UI
{
    public partial class EmployeeManagement : Form
    {
        private readonly IDataProvider _dataProvider;
        private int _currentPage;
        private string _currentSearch;
        private readonly ILogger Logger;
        public EmployeeManagement(ILogger logger)
        {
            InitializeComponent();
            _currentPage = 1;
            _dataProvider = ProviderFactory.GetDataProvider(logger, ConfigurationManager.AppSettings);
            Logger = logger;
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // Load the first page of employees on startup
            PopulateEmployeeGrid();
        }

        private async void PopulateEmployeeGrid()
        {
            var employeeResponse = await _dataProvider.GetEmployeesByPage(_currentPage, _currentSearch);
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
    }
}

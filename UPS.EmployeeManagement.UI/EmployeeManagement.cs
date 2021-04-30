using Serilog;
using System;
using System.Windows.Forms;
using UPS.EmployeeManagement.Services.Providers;

namespace UPS.EmployeeManagement.UI
{
  public partial class EmployeeManagement : Form
    {
        public EmployeeManagement(ILogger logger)
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // test the API
            var apiDataProvider = new APIDataProvider(Log.Logger);
            var employees = apiDataProvider.GetEmployees();
        }
    }
}

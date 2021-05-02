using System;
using System.Windows.Forms;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.UI
{
    public partial class UpsertEmployee : Form
    {
        public Employee Employee;

        public UpsertEmployee(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void PopulateEmployeeDetails()
        {
            if (Employee == null)
            {
                Text = "Add Employee";
                btnUpsert.Text = "Add";
                return;
            }

            txtName.Text = Employee.name;
            txtEmail.Text = Employee.email;
            if (Employee.gender.ToLower() == "male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }

            chkStatus.Checked = Employee.status.ToLower() == "active";

            Text = "Update Employee";
            btnUpsert.Text = "Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            // Ensure Employee is valid
            if (Employee == null)
            {
                Employee = new Employee();
            }
            
            // Validate Name
            Employee.name = txtName.Text;
            Employee.email = txtEmail.Text;
            Employee.gender = radioMale.Checked ? "Male" : "Female";
            Employee.status = chkStatus.Checked ? "Active" : "Inactive";

            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpsertEmployee_Load(object sender, EventArgs e)
        {
            PopulateEmployeeDetails();
        }
    }
}

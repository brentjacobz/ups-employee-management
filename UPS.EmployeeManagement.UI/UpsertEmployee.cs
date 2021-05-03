using System;
using System.ComponentModel.DataAnnotations;
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
            ddlFilterGender.SelectedItem = Employee.gender;
            ddlFilterStatus.SelectedItem = Employee.status;

            Text = "Update Employee";
            btnUpsert.Text = "Update";
        }

        private bool AreEmployeeFieldsValid()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty");
                return false;
            }
                
            var emailAddressAttribute = new EmailAddressAttribute();
            if (!emailAddressAttribute.IsValid(txtEmail.Text))
            {
                MessageBox.Show("Email address is not the correct format");
                return false;
            }

            if (ddlFilterGender.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select either Male or Female");
                return false;
            }

            if (ddlFilterStatus.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select status");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            if (!AreEmployeeFieldsValid())
            {
                return;
            }
            // Ensure Employee is valid
            if (Employee == null)
            {
                Employee = new Employee();
            }
            
            // Validate Name
            Employee.name = txtName.Text;
            Employee.email = txtEmail.Text;
            Employee.gender = ddlFilterGender.SelectedItem.ToString();
            Employee.status = ddlFilterStatus.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpsertEmployee_Load(object sender, EventArgs e)
        {
            PopulateEmployeeDetails();
        }
    }
}

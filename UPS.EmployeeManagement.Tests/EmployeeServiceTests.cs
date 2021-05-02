using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Serilog;
using UPS.EmployeeManagement.Services;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Responses;
using System.Collections.Generic;

namespace UPS.EmployeeManagement.Tests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private readonly IEmployeeService employeeService;
        private readonly Mock<IEmployeeRepository> employeeRepository = new Mock<IEmployeeRepository>();
        private readonly Mock<ILogger> logger = new Mock<ILogger>();

        public EmployeeServiceTests()
        {
            employeeService = new EmployeeService(logger.Object, employeeRepository.Object);
        }

        [TestInitialize]
        public void Initialise()
        {
            // All employees
            var allEmployees = new EmployeeResponse
            {
                Employees = new List<Employee>
                {
                    new Employee { name = "MS Doni", email = "ms.doni@calcuttaknightriders.com", gender = "Male", status = "Active"},
                    new Employee { name = "Abby Wambach", email = "abby.wambach@usa.com", gender = "Female", status = "Active"},
                    new Employee { name = "Harry Kane", email = "Harry.Kane@spurs.co.uk", gender = "Male", status = "Active"},
                    new Employee { name = "Hope Solo", email = "Hope.Solo@football.com", gender = "Female", status = "Inactive"}
                }
            };

            employeeRepository.Setup(e => e.ListEmployees(It.Is<EmployeeFilter>(fe => fe.PageNumber == 1))).ReturnsAsync(allEmployees);

            // Female employees
            var femaleEmployees = new EmployeeResponse
            {
                Employees = new List<Employee>
                {
                    new Employee { name = "Abby Wambach", email = "abby.wambach@usa.com", gender = "Female", status = "Active"},
                    new Employee { name = "Hope Solo", email = "Hope.Solo@football.com", gender = "Female", status = "Inactive"}
                }
            };

            employeeRepository.Setup(e => e.ListEmployees(It.Is<EmployeeFilter>(fe => fe.gender == "Female"))).ReturnsAsync(femaleEmployees);

            // Inactive employees
            var inactiveEmployees = new EmployeeResponse
            {
                Employees = new List<Employee>
                {
                    new Employee { name = "Hope Solo", email = "Hope.Solo@football.com", gender = "Female", status = "Inactive"}
                }
            };

            employeeRepository.Setup(e => e.ListEmployees(It.Is<EmployeeFilter>(fe => fe.status == "Inactive"))).ReturnsAsync(inactiveEmployees);

            var successResponse = new EmployeeResponse
            {
                Success = true
            };
            // Add Employee
            employeeRepository.Setup(e => e.AddEmployee(It.IsAny<Employee>())).ReturnsAsync(successResponse);
            // Update Employee
            employeeRepository.Setup(e => e.UpdateEmployee(It.IsAny<Employee>())).ReturnsAsync(successResponse);
            // Delete Employee
            employeeRepository.Setup(e => e.DeleteEmployee(555)).ReturnsAsync(successResponse);
        }

        [TestMethod]
        public async Task Should_get_all_employees()
        {
            var response = await employeeService.GetEmployeesByPage(new EmployeeFilter { PageNumber = 1 });
            Assert.AreEqual(response.Employees.Count, 4);
        }

        [TestMethod]
        public async Task Should_get_all_female_employees()
        {
            var response = await employeeService.GetEmployeesByPage(new EmployeeFilter { gender = "Female" });
            Assert.AreEqual(response.Employees.Count, 2);
        }

        [TestMethod]
        public async Task Should_get_all_inactive_employees()
        {
            var response = await employeeService.GetEmployeesByPage(new EmployeeFilter { status = "Inactive" });
            Assert.AreEqual(response.Employees.Count, 1);
        }

        [TestMethod]
        public async Task Should_be_able_to_add_employee()
        {
            var newEmployee = new Employee
            {
                name = "Tim Burton",
                email = "tim.burton@director.com",
                status = "Active",
                gender = "Male"
            };

            var response = await employeeService.AddEmployee(newEmployee);
            Assert.AreEqual(response.Success, true);
        }

        [TestMethod]
        public async Task Should_be_able_to_update_employee()
        {
            var newEmployee = new Employee
            {
                name = "Sandra Bullock",
                email = "sandra.bullock@hollywood.com",
                status = "Active",
                gender = "Female"
            };

            var response = await employeeService.UpdateEmployee(newEmployee);
            Assert.AreEqual(response.Success, true);
        }

        [TestMethod]
        public async Task Should_be_able_to_delete_employee_by_employee_id()
        {
            var employeeId = 555;
            var response = await employeeService.DeleteEmployee(employeeId);
            Assert.AreEqual(response.Success, true);
        }

        
    }
}

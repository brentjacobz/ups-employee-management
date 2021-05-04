using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPS.EmployeeManagement.Services.Export;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Tests
{
    [TestClass]
    public class EmployeeExportTests
    {
        [TestMethod]
        public void Should_export_all_the_employees_in_csv()
        {
            var employees = new List<Employee>
            {
                new Employee { id = 32, name = "Gov. Datta Saini", email = "datta_saini_gov@mcglynn-flatley.info", gender = "Male", status = "Inactive", created_at = DateTime.Parse("2021-05-04T00:20:04"), updated_at = DateTime.Parse("2021-05-04T00:20:04")},
                new Employee { id = 51, name = "Leela Devar", email = "leela_devar@kling.org", gender = "Female", status = "Active", created_at = DateTime.Parse("2021-05-04T00:20:04"), updated_at = DateTime.Parse("2021-05-04T00:20:04") }
            };

            var export = EmployeeExport.ExportEmployeeToCsv(employees);
	    Assert.AreEqual("id,name,email,gender,status,created_at,updated_at\r\n" +
                        "32,Gov. Datta Saini,datta_saini_gov@mcglynn-flatley.info,Male,Inactive,2021-05-04T00:20:04,2021-05-04T00:20:04\r\n" +
                        "51,Leela Devar,leela_devar@kling.org,Female,Active,2021-05-04T00:20:04,2021-05-04T00:20:04\r\n", export);
        }




        
    }
}

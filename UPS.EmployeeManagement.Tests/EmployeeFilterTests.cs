using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Tests
{
    [TestClass]
    public class EmployeeFilterTests
    {
        [TestInitialize]
        public void Initialise()
        {

        }

        [TestMethod]
        public void Query_string_should_just_contain_page_number()
        {
            var pageFilter = new EmployeeFilter { PageNumber = 1 };
            var queryString = pageFilter.GetQueryStringFilter();
            Assert.AreEqual("?page=1", queryString);
        }

        [TestMethod]
        public void Query_string_should_contain_page_number_and_name()
        {
            var pageFilter = new EmployeeFilter { PageNumber = 1, name = "Deep" };
            var queryString = pageFilter.GetQueryStringFilter();
            Assert.AreEqual("?page=1&name=Deep", queryString);
        }

        [TestMethod]
        public void Query_string_should_contain_page_number_and_name_and_gender()
        {
            var pageFilter = new EmployeeFilter { PageNumber = 1, name = "Deep", gender = "Female" };
            var queryString = pageFilter.GetQueryStringFilter();
            Assert.AreEqual("?page=1&name=Deep&gender=Female", queryString);
        }

        [TestMethod]
        public void Query_string_should_contain_page_number_and_name_and_gender_and_status()
        {
            var pageFilter = new EmployeeFilter { PageNumber = 1, name = "Deep", gender = "Female", status = "Inactive" };
            var queryString = pageFilter.GetQueryStringFilter();
            Assert.AreEqual("?page=1&name=Deep&gender=Female&status=Inactive", queryString);
        }
    }
}

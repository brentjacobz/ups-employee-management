using System.Collections.Generic;
using UPS.EmployeeManagement.Services.Dtos;

namespace UPS.EmployeeManagement.Services.Responses
{
    public class EmployeeResponse
    {
        public bool Success { get; set; }
        public string ResponseMessage { get; set; }
        public Pagination PageInformation { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

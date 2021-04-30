using System.Collections.Generic;
using UPS.EmployeeManagement.Services.Dtos;

namespace UPS.EmployeeManagement.Services.Models
{
    public class EmployeeResponse
    {
        public Pagination PageInformation { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

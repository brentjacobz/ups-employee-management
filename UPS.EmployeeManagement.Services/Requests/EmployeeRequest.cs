using UPS.EmployeeManagement.Services.Enums;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Requests
{
    public class EmployeeRequest
    {
        public EmployeeAction Action { get; set; }
        public int? PageNumber { get; set; }
        public string Search { get; set; }
        public Employee Employee { get; set; }
    }
}

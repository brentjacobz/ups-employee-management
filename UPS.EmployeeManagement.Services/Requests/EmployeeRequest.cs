using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Enums;

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

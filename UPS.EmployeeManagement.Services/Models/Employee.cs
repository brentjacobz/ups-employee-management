using System;

namespace UPS.EmployeeManagement.Services.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
  }
}

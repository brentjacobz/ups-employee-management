using System;

namespace UPS.EmployeeManagement.Services.Models
{
    public class Employee
    {
        public long id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}

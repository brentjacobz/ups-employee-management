using System.Collections.Generic;
using System.Globalization;
using System.Text;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Export
{
    public static class EmployeeExport
    {
        public static string ExportEmployeeToCsv(List<Employee> employees)
        {
            var sb = new StringBuilder();
            // Add the header
            sb.AppendLine("id,name,email,gender,status,created_at,updated_at");
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.id},{employee.name},{employee.email},{employee.gender},{employee.status}," +
                              $"{employee.created_at.ToString("s", DateTimeFormatInfo.InvariantInfo)}," +
                              $"{employee.updated_at.ToString("s", DateTimeFormatInfo.InvariantInfo)}");
            }
            return sb.ToString();
        }
    }
}

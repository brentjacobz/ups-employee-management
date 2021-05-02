using System;
using System.Runtime.InteropServices;

namespace UPS.EmployeeManagement.Services.Models
{
    public class EmployeeFilter : Employee
    {
        public int PageNumber { get; set; }

        public string GetQueryStringFilter()
        {
            var queryString = $"?page={PageNumber}";
            if (!string.IsNullOrEmpty(name))
                queryString = $"{queryString}&name={name}";

            if (!string.IsNullOrEmpty(email))
                queryString = $"{queryString}&email={email}";

            if (!string.IsNullOrEmpty(gender))
                queryString = $"{queryString}&gender={gender}";

            if (!string.IsNullOrEmpty(status))
                queryString = $"{queryString}&status={status}";

            return queryString;
        }
    }


}

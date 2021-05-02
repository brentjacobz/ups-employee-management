using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IQueryFilter
    {
        string GetQueryStringFilter(EmployeeFilter employeeFilter);
    }
}

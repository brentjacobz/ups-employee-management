using System.Collections.Generic;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IDataProvider
    {
        Task<List<Employee>> GetEmployees();
    }
}

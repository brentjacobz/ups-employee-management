using System.Collections.Generic;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IDataProvider
    {
        Task<EmployeeResponse> GetEmployeesByPage(int pageNumber, string nameFilter);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}

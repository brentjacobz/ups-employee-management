using System.Collections.Generic;
using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<EmployeeResponse> ListEmployees(int page, string nameSearch);
        Task<EmployeeResponse> AddEmployee(Employee employee);
        Task<EmployeeResponse> UpdateEmployee(Employee employee);
        Task<EmployeeResponse> DeleteEmployee(long employeeId);
    }
}

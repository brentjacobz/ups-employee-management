using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Models;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeResponse> GetEmployeesByPage(EmployeeFilter employeeFilter);
        Task<EmployeeResponse> AddEmployee(Employee employee);
        Task<EmployeeResponse> UpdateEmployee(Employee employee);
        Task<EmployeeResponse> DeleteEmployee(long employeeId);
    }
}

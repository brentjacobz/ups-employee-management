using System.Threading.Tasks;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeResponse> GetEmployeesByPage(int page, string nameSearch);
        Task<EmployeeResponse> AddEmployee(Employee employee);
        Task<EmployeeResponse> UpdateEmployee(Employee employee);
        Task<EmployeeResponse> DeleteEmployee(long employeeId);
    }
}

using System.Collections.Specialized;
using System.Threading.Tasks;
using Serilog;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Providers;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services
{
    public class EmployeeService : ServiceBase, IEmployeeService
    {
        private readonly ILogger _logger;
        private readonly IEmployeeRepository _employeeRepository;
        #region Constructors

        public EmployeeService(ILogger logger, NameValueCollection configurationSettings) : base(logger)
        {
            _logger = logger;
            _employeeRepository = ProviderFactory.GetDataProvider(logger, configurationSettings);
        }

        #endregion

        #region Public Methods

        public async Task<EmployeeResponse> GetEmployeesByPage(int page, string nameSearch)
        {
            var employeeResponse = await _employeeRepository.ListEmployees(page, nameSearch);
            return employeeResponse;
        }

        public async Task<EmployeeResponse> AddEmployee(Employee employee)
        {
            var employeeResponse = await _employeeRepository.AddEmployee(employee);
            return employeeResponse;
        }

        public async Task<EmployeeResponse> UpdateEmployee(Employee employee)
        {
            var employeeResponse = await _employeeRepository.UpdateEmployee(employee);
            return employeeResponse;
        }

        public async Task<EmployeeResponse> DeleteEmployee(long employeeId)
        {
            var employeeResponse = await _employeeRepository.DeleteEmployee(employeeId);
            return employeeResponse;
        }

        #endregion
    }
}

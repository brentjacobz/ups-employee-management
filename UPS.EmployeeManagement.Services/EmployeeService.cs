using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Serilog;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;
using UPS.EmployeeManagement.Services.Providers;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services
{
    public class EmployeeService : ServiceBase, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        #region Constructors

        public EmployeeService(ILogger logger, IEmployeeRepository employeeRepository)
            : base(logger)
        {
            _employeeRepository = employeeRepository;
        }

        #endregion

        #region Public Methods

        public async Task<EmployeeResponse> GetEmployeesByPage(EmployeeFilter employeeFilter)
        {
            try
            {
                var employeeResponse = await _employeeRepository.ListEmployees(employeeFilter);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                throw;
            }

        }

        public async Task<EmployeeResponse> AddEmployee(Employee employee)
        {
            try
            {
                var employeeResponse = await _employeeRepository.AddEmployee(employee);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                throw;
            }

        }

        public async Task<EmployeeResponse> UpdateEmployee(Employee employee)
        {
            try
            {
                var employeeResponse = await _employeeRepository.UpdateEmployee(employee);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                throw;
            }
        }

        public async Task<EmployeeResponse> DeleteEmployee(long employeeId)
        {
            try
            {
                var employeeResponse = await _employeeRepository.DeleteEmployee(employeeId);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                throw;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;
using UPS.EmployeeManagement.Services.Responses;

namespace UPS.EmployeeManagement.Services.Providers
{
    public class EmployeeWebAPIClient : IEmployeeRepository
    {
        private readonly HttpClient _httpClient;

        private readonly ILogger _logger;
        private const string _baseUrl = "https://gorest.co.in/public-api/";
        private const string _users = "users";

        public EmployeeWebAPIClient(ILogger logger, string apiToken)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
            _logger = logger;
        }

        public async Task<EmployeeResponse> ListEmployees(EmployeeFilter filter)
        {
            var url = $"{_baseUrl}{_users}";
            url = $"{url}{filter.GetQueryStringFilter()}";

            // Default Employee Response
            EmployeeResponse employeeResponse;

            using (var response = await _httpClient.GetAsync(url))
            {
                employeeResponse = await CreateEmployeeResponse(response, true);
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> AddEmployee(Employee employee)
        {
            if (employee == null)
                return null;
            // Default Employee Response
            EmployeeResponse employeeResponse;

            var url = $"{_baseUrl}{_users}";
            var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            using (var response = await _httpClient.PostAsync(url, content))
            {
                employeeResponse = await CreateEmployeeResponse(response);
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> UpdateEmployee(Employee employee)
        {
            if (employee == null)
                return null;
            // Default Employee Response
            EmployeeResponse employeeResponse;

            var url = $"{_baseUrl}{_users}";
            url = $"{url}/{employee.id}";
            var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            using (var response = await _httpClient.PutAsync(url, content))
            {
                employeeResponse = await CreateEmployeeResponse(response);
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> DeleteEmployee(long employeeId)
        {
            var url = $"{_baseUrl}{_users}";
            url = $"{url}/{employeeId}";
            using (var response = await _httpClient.DeleteAsync(url))
            {
                return await CreateEmployeeResponse(response);
            }
        }

        public async Task<EmployeeResponse> CreateEmployeeResponse(HttpResponseMessage httpResponseMessage, bool shouldRetrieveList = false)
        {
            var operation = shouldRetrieveList ? "list" : "CRUD";
            // Default Employee Response
            var employeeResponse = new EmployeeResponse
            {
                Success = true,
                ResponseMessage = shouldRetrieveList ? "List/Search operation successful" : "CRUD operation successful"
            };
            int[] successCodes = { 200, 201, 204 };
            // Check to see that we have a response from the server
            if (httpResponseMessage == null)
            {
                return employeeResponse;
            }

            try
            {
                // Check if an error occured on the server
                if (!httpResponseMessage.IsSuccessStatusCode)
                {
                    employeeResponse.Success = false;
                    employeeResponse.ResponseMessage = httpResponseMessage.ReasonPhrase;
                }
                else
                {
                    var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
                    if (shouldRetrieveList)
                    {
                        var listEmployeeResponse = JsonConvert.DeserializeObject<ListEmployeeResponse>(responseContent);
                        employeeResponse.Employees = new List<Employee>(listEmployeeResponse.Data);
                        employeeResponse.PageInformation = listEmployeeResponse.Meta.Pagination;
                    }
                    else
                    {
                        var crudEmployeeResponse = JsonConvert.DeserializeObject<CRUDEmployeeResponse>(responseContent);
                        // Check if there's a logic error (deleting or updating an employee that doesn't exist)
                        if (!successCodes.Contains(crudEmployeeResponse.code))
                        {
                            employeeResponse.Success = false;
                            employeeResponse.ResponseMessage = crudEmployeeResponse.data.message;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
                employeeResponse.Success = false;

                employeeResponse.ResponseMessage = $"An error occured during {operation}. See log for details.";
            }

            return employeeResponse;
        }
    }
}

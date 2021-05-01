using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Serilog;
using Serilog.Core;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Interfaces;
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

        public async Task<EmployeeResponse> ListEmployees(int page, string nameSearch)
        {
            var url = $"{_baseUrl}{_users}";
            // update with page number if provided
            url = $"{url}?page={page}";
            if (!string.IsNullOrEmpty(nameSearch)) url = $"{url}&name={nameSearch}";

            // Default Employee Response
            var employeeResponse = new EmployeeResponse
            {
                Success = true,
                Employees = new List<Employee>()
            };

            using (var response = await _httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var goRestResponse = JsonConvert.DeserializeObject<GoRestResponse>(content);
                    employeeResponse.Employees.AddRange(goRestResponse.Data);
                }

                employeeResponse.Success = false;
                employeeResponse.ResponseMessage = response.ReasonPhrase;
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> AddEmployee(Employee employee)
        {
            if (employee == null)
                return null;
            // Default Employee Response
            var employeeResponse = new EmployeeResponse { Success = true };

            var url = $"{_baseUrl}{_users}";
            var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            using (var response = await _httpClient.PostAsync(url, content))
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                    return employeeResponse;

                employeeResponse.Success = false;
                employeeResponse.ResponseMessage = response.ReasonPhrase;
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> UpdateEmployee(Employee employee)
        {
            if (employee == null)
                return null;
            // Default Employee Response
            var employeeResponse = new EmployeeResponse {Success = true};

            var url = $"{_baseUrl}{_users}";
            url = $"{url}/{employee.id}";
            var content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            using (var response = await _httpClient.PutAsync(url, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return employeeResponse;
                }

                employeeResponse.Success = false;
                employeeResponse.ResponseMessage = response.ReasonPhrase;
            }

            return employeeResponse;
        }

        public async Task<EmployeeResponse> DeleteEmployee(long employeeId)
        {
            // Default Employee Response
            var employeeResponse = new EmployeeResponse { Success = true };

            var url = $"{_baseUrl}{_users}";
            url = $"{url}/{employeeId}";
            using (HttpResponseMessage response = await _httpClient.DeleteAsync(url))
            {
                if (!response.IsSuccessStatusCode)
                {
                    employeeResponse.Success = false;
                    employeeResponse.ResponseMessage = response.ReasonPhrase;
                }

                return employeeResponse;
            }
        }
    }
}

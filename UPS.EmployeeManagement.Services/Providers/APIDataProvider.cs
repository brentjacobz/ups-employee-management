using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UPS.EmployeeManagement.Services.Dtos;
using UPS.EmployeeManagement.Services.Enums;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Providers
{
    public class APIDataProvider : DataProvider, IDataProvider
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://gorest.co.in/public-api/";
        private const string _users = "users";
        private readonly string _apiToken;

        #region Constructors

        public APIDataProvider(ILogger logger, string apiToken) : base(logger)
        {
            _httpClient = new HttpClient();
            _apiToken = apiToken;
        }

        #endregion

        #region Public Methods

        public async Task<EmployeeResponse> GetEmployeesByPage(int pageNumber, string nameFilter)
        {
            var employeeResponse = await RequestData(EmployeeAction.List, pageNumber, nameFilter);
            return employeeResponse;
        }

        public async Task<EmployeeResponse> SearchEmployeeByName(string name)
        {
            var employeeResponse = await RequestData(EmployeeAction.Search, null, name);
            return employeeResponse;
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private async Task<EmployeeResponse> RequestData(EmployeeAction employeeAction, int? page, string name)
        {
			// Get the HttpMethod based on the action.
            var httpMethod = GetHttpMethodByAction(employeeAction);
            // Default Employee Response
            var employeeResponse = new EmployeeResponse
            {
                Employees = new List<Employee>()
            };

            var url = $"{_baseUrl}{_users}";
            // update with page number if provided
            if (page.HasValue) url = $"{url}?page={page}";
            if (!string.IsNullOrEmpty(name)) url = $"{url}&name={name}";

            using (var request = new HttpRequestMessage(httpMethod, url))
            {
                try
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _apiToken);
                    var response = await _httpClient.SendAsync(request);

                    var content = response.Content.ReadAsStringAsync().Result;
                    var goRestResponse = JsonConvert.DeserializeObject<GoRestResponse>(content);

                    if (goRestResponse.Code == 200) // Status = OK
                    {
                        employeeResponse.Employees.AddRange(goRestResponse.Data);
                        employeeResponse.PageInformation = goRestResponse.Meta.Pagination;
                    }
                    else
                    {
                        Logger.Warning($"The status returned from the API was: {goRestResponse.Code}. No data was returned...");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "An error occured while trying to retrieve the employees.");
                }
            }

            return employeeResponse;
        }

        private static HttpMethod GetHttpMethodByAction(EmployeeAction employeeAction)
        {
            switch (employeeAction)
            {
                case EmployeeAction.Add:
                    return HttpMethod.Post;
                case EmployeeAction.Delete:
                    return HttpMethod.Delete;
                case EmployeeAction.Update:
                    return HttpMethod.Put;
            }
            return HttpMethod.Get;
        }

        #endregion
    }
}

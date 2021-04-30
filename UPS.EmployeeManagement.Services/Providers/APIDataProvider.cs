using System;
using Serilog;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Threading.Tasks;
using Newtonsoft.Json;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Models;

namespace UPS.EmployeeManagement.Services.Providers
{
    public class APIDataProvider : DataProvider, IDataProvider
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://gorest.co.in/public-api/";
        private const string _users = "users";

        public APIDataProvider (ILogger logger) : base(logger)
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = new List<Employee>();
            using (var request = new HttpRequestMessage(HttpMethod.Get, $"{_baseUrl}{_users}"))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer" , "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                var response = await _httpClient.SendAsync(request);
                try
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var users = JsonConvert.DeserializeObject<Employee[]>(content);
                    employees.AddRange(users);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "An error occured while parsing the users response.");
                }
            }

            return employees;
        }
    }
}

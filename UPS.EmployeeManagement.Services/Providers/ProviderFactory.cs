using System;
using System.Collections.Specialized;
using Serilog;
using UPS.EmployeeManagement.Services.Interfaces;

namespace UPS.EmployeeManagement.Services.Providers
{
    public static class ProviderFactory
    {
        public static IEmployeeRepository GetDataProvider(ILogger logger, NameValueCollection appSettings)
        {
            if (appSettings["APIToken"] != null)
            {
				return new EmployeeWebAPIClient(logger, appSettings["APIToken"]);
            }

			throw new Exception("Could not create Data Provider");
        }
    }
}

using System;
using System.Collections.Specialized;
using Serilog;
using UPS.EmployeeManagement.Services.Interfaces;
using UPS.EmployeeManagement.Services.Providers;

namespace UPS.EmployeeManagement.Services
{
    public static class ServiceFactory
    {
        public static IEmployeeService CreateEmployeeService(ILogger logger, NameValueCollection appSettings)
        {
            // We need to check that the "DataProvider" in the app.config is configured to be a "WebAPI". Then we need to check that an APIToken has been provided.
            if (appSettings["DataProvider"] != null && appSettings["DataProvider"] == "WebAPI")
            {
                if (appSettings["WebAPIToken"] != null)
                {
                    var repository = new EmployeeWebAPIClient(logger, appSettings["WebAPIToken"]);
		    return new EmployeeService(logger, repository);
                }
                logger.Error("WebAPI was configured as the DataProvider, but no WebAPIToken was provided.");
            }

            logger.Error("Could not create data provider for Employee Service. ");

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using UPS.EmployeeManagement.Services.Interfaces;

namespace UPS.EmployeeManagement.Services.Providers
{
    public static class ProviderFactory
    {
        public static IDataProvider GetDataProvider(ILogger logger, NameValueCollection appSettings)
        {
            if (appSettings["APIToken"] != null)
            {
				return new APIDataProvider(logger, appSettings["APIToken"]);
            }

			throw new Exception("Could not create Data Provider");
        }
    }
}

using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.EmployeeManagement.Services.Providers
{
    public abstract class DataProvider
    {
        protected readonly ILogger Logger;
        protected DataProvider (ILogger logger)
        {
            Logger = logger;
        }
    }
}

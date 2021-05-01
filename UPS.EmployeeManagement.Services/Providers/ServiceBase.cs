using Serilog;

namespace UPS.EmployeeManagement.Services.Providers
{
    public abstract class ServiceBase
    {
        protected readonly ILogger Logger;
        protected ServiceBase(ILogger logger)
        {
            Logger = logger;
        }
    }
}

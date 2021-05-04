using Serilog;

namespace UPS.EmployeeManagement.Services.Providers
{
    public abstract class ServiceBase
    {
        protected readonly ILogger _logger;
        protected ServiceBase(ILogger logger)
        {
            _logger = logger;
        }
    }
}

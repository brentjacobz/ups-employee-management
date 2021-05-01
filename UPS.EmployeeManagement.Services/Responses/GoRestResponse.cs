using UPS.EmployeeManagement.Services.Dtos;

namespace UPS.EmployeeManagement.Services.Responses
{
    public class GoRestResponse
    {
        public int Code { get; set; }
        public MetaData Meta { get; set; }
        public Employee[] Data { get; set; }
    }
}

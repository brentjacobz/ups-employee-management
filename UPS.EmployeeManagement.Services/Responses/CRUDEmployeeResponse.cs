namespace UPS.EmployeeManagement.Services.Responses
{
    public class CRUDEmployeeResponse
    {
        public ResponseData data { get; set; }
        public int code { get; set; }
    }

    public class ResponseData
    {
        public string message { get; set; }
    }
}

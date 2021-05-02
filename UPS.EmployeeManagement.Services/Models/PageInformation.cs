namespace UPS.EmployeeManagement.Services.Models
{
    public class MetaData
    {
        public Pagination Pagination { get; set; }
    }

    public class Pagination
    {
        public int Total { get; set; }
        public int Pages { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}

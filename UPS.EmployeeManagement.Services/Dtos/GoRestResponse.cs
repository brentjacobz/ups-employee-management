namespace UPS.EmployeeManagement.Services.Dtos
{
    public class GoRestResponse
    {
        public int Code { get; set; }
        public MetaData Meta { get; set; }
		public Employee[] Data { get; set; }
    }
}

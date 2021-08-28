namespace ServiceManagement.Application.Contract.Services
{
    public class ServicesViewModel
    {
        public long Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceLogo { get; set; }
        public string ServiceDescription { get; set; }
        public string CreationDate { get; set; }
    }
}

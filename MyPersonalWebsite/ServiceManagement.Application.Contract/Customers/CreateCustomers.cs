using Microsoft.AspNetCore.Http;

namespace ServiceManagement.Application.Contract.Customers
{
    public class CreateCustomers
    {
        public string CustomerName { get; set; }
        public IFormFile CustomerLogo { get; set; }
        public string LogoAlt { get; set; }
        public string LogoTitle { get; set; }
    }
}

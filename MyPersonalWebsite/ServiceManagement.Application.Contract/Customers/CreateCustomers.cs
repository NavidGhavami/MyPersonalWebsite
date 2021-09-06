using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace ServiceManagement.Application.Contract.Customers
{
    public class CreateCustomers
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile CustomerLogo { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string LogoAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string LogoTitle { get; set; }
    }
}

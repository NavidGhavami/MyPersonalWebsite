using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.Services
{
    public class CreateServices
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ServiceName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ServiceLogo { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ServiceDescription { get; set; }
    }
}

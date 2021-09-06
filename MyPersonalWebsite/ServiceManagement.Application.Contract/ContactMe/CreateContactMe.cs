using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.ContactMe
{
    public class CreateContactMe
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Email { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Message { get; set; }
    }
}

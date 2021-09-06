using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ServiceManagement.Application.Contract.ClientsOpinion
{
    public class CreateClientsOpinion
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ClientName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ClientJob { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
    }
}

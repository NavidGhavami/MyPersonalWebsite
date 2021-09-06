using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ProjectManagement.Application.Contract.ProjectCategory
{
    public class CreateProjectCategory
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }
    }
}

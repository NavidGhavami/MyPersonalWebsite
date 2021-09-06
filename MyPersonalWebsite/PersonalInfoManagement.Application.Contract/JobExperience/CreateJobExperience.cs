using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.JobExperience
{
    public class CreateJobExperience
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string JobPosition { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string WorkDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
    }
}

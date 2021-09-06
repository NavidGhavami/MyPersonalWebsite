using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.EducationExperience
{
    public class CreateEducationExperience
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string UniversityName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string EducationDegree { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string EducationCourse { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string EducationDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
    }

}

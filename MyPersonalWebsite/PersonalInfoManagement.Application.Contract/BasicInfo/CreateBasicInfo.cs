using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace PersonalInfoManagement.Application.Contract.BasicInfo
{
    public class CreateBasicInfo
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Family { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Age { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Nationality { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Job { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Address { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Email { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Instagram { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Language { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Experience { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string CompleteProject { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string HappyCustomers { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Articles { get; set; }

        public IFormFile PersianResume { get; set; }
        public IFormFile EnglishResume { get; set; }
        public IFormFile RecommendationLetters { get; set; }

    }
}

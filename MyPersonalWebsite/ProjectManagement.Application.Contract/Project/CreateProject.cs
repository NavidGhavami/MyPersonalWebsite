using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ProjectManagement.Application.Contract.Project
{
    public class CreateProject
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Customer { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Technology { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile FirstPicture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile SecondPicture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile ThirdPicture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public IFormFile ForthPicture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string UrlLink { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }
        public List<ProjectCategoryViewModel> Category { get; set; }
    }
}

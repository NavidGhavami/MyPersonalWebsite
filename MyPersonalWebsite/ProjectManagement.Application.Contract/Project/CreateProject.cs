using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ProjectManagement.Application.Contract.Project
{
    public class CreateProject
    {
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Technology { get; set; }
        public IFormFile FirstPicture { get; set; }
        public IFormFile SecondPicture { get; set; }
        public IFormFile ThirdPicture { get; set; }
        public IFormFile ForthPicture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string UrlLink { get; set; }
        public long CategoryId { get; set; }
        public string Description { get; set; }
        public List<ProjectCategoryViewModel> Category { get; set; }
    }
}

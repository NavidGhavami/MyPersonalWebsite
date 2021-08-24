using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Project;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class ProjectQuery : IProjectQuery
    {
        private readonly ProjectContext _projectContext;

        public ProjectQuery(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public List<ProjectQueryModel> GetProjects()
        {
            return _projectContext.Projects
                .Include(x => x.Category)
                .Select(x => new ProjectQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Customer = x.Customer,
                    Technology = x.Technology,
                    Description = x.Description,
                    CategoryName = x.Category.Name,
                    FirstPicture = x.FirstPicture,
                    SecondPicture = x.SecondPicture,
                    ThirdPicture = x.ThirdPicture,
                    ForthPicture = x.ForthPicture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    UrlLink = x.UrlLink,

                }).OrderByDescending(x=>x.Id).ToList();
        }

        public ProjectQueryModel GetProjectDetails(string slug)
        {
            return _projectContext.Projects
                .Include(x => x.Category)
                .Select(x => new ProjectQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Customer = x.Customer,
                    Technology = x.Technology,
                    Description = x.Description,
                    CategoryName = x.Category.Name,
                    FirstPicture = x.FirstPicture,
                    SecondPicture = x.SecondPicture,
                    ThirdPicture = x.ThirdPicture,
                    ForthPicture = x.ForthPicture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    UrlLink = x.UrlLink,

                }).FirstOrDefault(x => x.Slug == slug);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Domain.Project;

namespace ProjectManagement.Infrastructure.EFCore.Repository
{
    public class ProjectRepository : RepositoryBase<long, Project>, IProjectRepository
    {
        private readonly ProjectContext _projectContext;
        public ProjectRepository(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public Project GetProjectWithCategory(long id)
        {
            return _projectContext.Projects
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
        }

        public EditProject GetDetails(long id)
        {
            return _projectContext.Projects.Select(x => new EditProject
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug,
                UrlLink = x.UrlLink,
                Customer = x.Customer,
                PictureAlt = x.PictureAlt,
                Technology = x.Technology,
                Description = x.Description,
                PictureTitle = x.PictureTitle,
                CategoryId = x.CategoryId

                

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProjectViewModel> GetProjects()
        {
            return _projectContext.Projects
                .Include(x=>x.Category)
                .Select(x => new ProjectViewModel
            {

                Id = x.Id,
                Name = x.Name,
                Customer = x.Customer,
                Category = x.Category.Name,
                CategoryId = x.CategoryId,
                FirstPicture = x.FirstPicture,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }
    }
}

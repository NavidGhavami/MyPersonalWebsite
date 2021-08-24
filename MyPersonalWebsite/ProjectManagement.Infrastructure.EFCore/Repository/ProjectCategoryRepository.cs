using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Application.Contract.ProjectCategory;
using ProjectManagement.Domain.ProjectCategory;

namespace ProjectManagement.Infrastructure.EFCore.Repository
{
    public class ProjectCategoryRepository : RepositoryBase<long, ProjectCategory>, IProjectCategoryRepository
    {
        private readonly ProjectContext _projectContext;
        public ProjectCategoryRepository(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public List<ProjectCategoryViewModel> GetProjectCategory()
        {
            return _projectContext.ProjectCategories.Select(x => new ProjectCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }

        public EditProjectCategory GetDetails(long id)
        {
            return _projectContext.ProjectCategories.Select(x => new EditProjectCategory
            {
                Id = x.Id,
                Name = x.Name

            }).FirstOrDefault(x => x.Id == id);
        }
    }
}

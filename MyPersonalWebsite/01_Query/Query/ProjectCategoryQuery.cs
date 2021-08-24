using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.ProjectCategory;
using ProjectManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class ProjectCategoryQuery : IProjectCategoryQuery
    {
        private readonly ProjectContext _projectContext;

        public ProjectCategoryQuery(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public List<ProjectCategoryQueryModel> GetProjectCategories()
        {
            return _projectContext.ProjectCategories.Select(x => new ProjectCategoryQueryModel
            {
                Name = x.Name


            }).ToList();
        }
    }
}

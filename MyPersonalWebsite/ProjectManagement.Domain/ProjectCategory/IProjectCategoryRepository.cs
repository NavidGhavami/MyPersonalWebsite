using System.Collections.Generic;
using _0_Framework.Domain;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ProjectManagement.Domain.ProjectCategory
{
    public interface IProjectCategoryRepository : IRepository<long, ProjectCategory>
    {
        List<ProjectCategoryViewModel> GetProjectCategory();
        EditProjectCategory GetDetails(long id);
    }
}

using System.Collections.Generic;
using _0_Framework.Domain;
using ProjectManagement.Application.Contract.Project;

namespace ProjectManagement.Domain.Project
{
    public interface IProjectRepository : IRepository<long, Project>
    {
        Project GetProjectWithCategory(long id);
        EditProject GetDetails(long id);
        List<ProjectViewModel> GetProjects();
    }
}

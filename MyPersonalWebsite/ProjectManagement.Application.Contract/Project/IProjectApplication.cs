using System.Collections.Generic;
using _0_Framework.Application;

namespace ProjectManagement.Application.Contract.Project
{
    public interface IProjectApplication
    {
        OperationResult Create(CreateProject command);
        OperationResult Edit(EditProject command);
        EditProject GetDetails(long id);
        List<ProjectViewModel> GetProjects();
    }
}

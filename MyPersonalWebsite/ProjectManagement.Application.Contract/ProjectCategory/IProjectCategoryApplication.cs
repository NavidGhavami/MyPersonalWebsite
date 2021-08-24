using System.Collections.Generic;
using _0_Framework.Application;

namespace ProjectManagement.Application.Contract.ProjectCategory
{
    public interface IProjectCategoryApplication
    {
        OperationResult Create(CreateProjectCategory command);
        OperationResult Edit(EditProjectCategory command);
        EditProjectCategory GetDetails(long id);
        List<ProjectCategoryViewModel> GetProjectCategory();

    }
}

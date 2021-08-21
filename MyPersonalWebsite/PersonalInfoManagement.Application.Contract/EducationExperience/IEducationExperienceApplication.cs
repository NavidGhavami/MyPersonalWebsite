using System.Collections.Generic;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.EducationExperience
{
    public interface IEducationExperienceApplication
    {
        OperationResult Create(CreateEducationExperience command);
        OperationResult Edit(EditEducationExperience command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditEducationExperience GetDetails(long id);
        List<EducationExperienceViewModel> GetList();
    }
}

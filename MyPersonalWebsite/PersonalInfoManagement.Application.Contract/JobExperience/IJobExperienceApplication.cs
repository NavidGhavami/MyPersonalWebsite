using System.Collections.Generic;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.JobExperience
{
    public interface IJobExperienceApplication 
    {
        OperationResult Create(CreateJobExperience command);
        OperationResult Edit(EditJobExperience command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditJobExperience GetDetails(long id);
        List<JobExperienceViewModel> GetList();
    }
}

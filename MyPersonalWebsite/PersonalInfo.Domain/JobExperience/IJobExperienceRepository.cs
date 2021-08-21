using System.Collections.Generic;
using _0_Framework.Domain;
using PersonalInfoManagement.Application.Contract.JobExperience;

namespace PersonalInfo.Domain.JobExperience
{
    public interface IJobExperienceRepository : IRepository<long, JobExperience>
    {
        EditJobExperience GetDetails(long id);
        List<JobExperienceViewModel> GetList();
    }
}

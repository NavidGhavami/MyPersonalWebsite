using System.Collections.Generic;

namespace _01_Query.Contract.JobExperience
{
    public interface IJobExperienceQuery
    {
        List<JobExperienceQueryModel> GetList();
    }
}

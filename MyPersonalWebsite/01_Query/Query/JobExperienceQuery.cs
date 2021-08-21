using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.JobExperience;
using PersonalInfoManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class JobExperienceQuery : IJobExperienceQuery
    {
        private readonly PersonalInfoContext _personalInfoContext;

        public JobExperienceQuery(PersonalInfoContext personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }


        public List<JobExperienceQueryModel> GetList()
        {
            return _personalInfoContext.JobExperiences
                .Where(x => x.IsRemoved == false)
                .Select(x => new JobExperienceQueryModel
                {
                    Id = x.Id,
                    IsRemoved = x.IsRemoved,
                    CompanyName = x.CompanyName,
                    JobPosition = x.JobPosition,
                    WorkDate = x.WorkDate,
                    Description = x.Description

                }).OrderByDescending(x => x.Id)
                .ToList();
        }
    }
}

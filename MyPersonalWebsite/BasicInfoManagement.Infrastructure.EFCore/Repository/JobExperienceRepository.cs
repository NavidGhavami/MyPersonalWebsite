using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using PersonalInfo.Domain.JobExperience;
using PersonalInfoManagement.Application.Contract.JobExperience;

namespace PersonalInfoManagement.Infrastructure.EFCore.Repository
{
    public class JobExperienceRepository : RepositoryBase<long, JobExperience>, IJobExperienceRepository
    {
        private PersonalInfoContext _personalInfoContext;
        public JobExperienceRepository(PersonalInfoContext personalInfoContext) : base(personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public EditJobExperience GetDetails(long id)
        {
            return _personalInfoContext.JobExperiences.Select(x => new EditJobExperience
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                JobPosition = x.JobPosition,
                WorkDate = x.WorkDate,
                Description = x.Description

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<JobExperienceViewModel> GetList()
        {
            return _personalInfoContext.JobExperiences.Select(x => new JobExperienceViewModel
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                JobPosition = x.JobPosition,
                WorkDate = x.WorkDate,
                Description = x.Description,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()

            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}

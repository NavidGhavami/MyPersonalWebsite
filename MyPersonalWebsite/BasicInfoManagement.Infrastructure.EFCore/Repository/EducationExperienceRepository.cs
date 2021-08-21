using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PersonalInfo.Domain.EducationExperience;
using PersonalInfoManagement.Application.Contract.EducationExperience;
using PersonalInfoManagement.Application.Contract.JobExperience;

namespace PersonalInfoManagement.Infrastructure.EFCore.Repository
{
    public class EducationExperienceRepository : RepositoryBase<long, EducationExperience>, IEducationExperienceRepository
    {
        private readonly PersonalInfoContext _personalInfoContext;
        public EducationExperienceRepository(PersonalInfoContext personalInfoContext) : base(personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public EditEducationExperience GetDetails(long id)
        {
            return _personalInfoContext.EducationExperiences.Select(x => new EditEducationExperience
            {
                Id = x.Id,
                UniversityName = x.UniversityName,
                EducationCourse = x.EducationCourse,
                EducationDegree = x.EducationDegree,
                EducationDate = x.EducationDate,
                Description = x.Description

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<EducationExperienceViewModel> GetList()
        {
            return _personalInfoContext.EducationExperiences.Select(x => new EducationExperienceViewModel
            {
                Id = x.Id,
                UniversityName = x.UniversityName,
                EducationCourse = x.EducationCourse,
                EducationDegree = x.EducationDegree,
                EducationDate = x.EducationDate,
                Description = x.Description,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()

            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}

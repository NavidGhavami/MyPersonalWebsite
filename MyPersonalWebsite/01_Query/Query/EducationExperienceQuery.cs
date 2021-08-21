using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.EducationExperience;
using PersonalInfoManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class EducationExperienceQuery : IEducationExperienceQuery
    {
        private readonly PersonalInfoContext _personalInfoContext;

        public EducationExperienceQuery(PersonalInfoContext personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public List<EducationExperienceQueryModel> GetList()
        {
            return _personalInfoContext.EducationExperiences
                .Where(x => x.IsRemoved == false)
                .Select(x => new EducationExperienceQueryModel
                {
                    Id= x.Id,
                    UniversityName = x.UniversityName,
                    EducationDegree = x.EducationDegree,
                    EducationCourse = x.EducationCourse,
                    EducationDate = x.EducationDate,
                    Description = x.Description

                }).OrderByDescending(x => x.Id).ToList();
        }
    }
}

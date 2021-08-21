using System.Collections.Generic;
using _0_Framework.Domain;
using PersonalInfoManagement.Application.Contract.EducationExperience;

namespace PersonalInfo.Domain.EducationExperience
{
    public interface IEducationExperienceRepository : IRepository<long, EducationExperience>
    {
        EditEducationExperience GetDetails(long id);
        List<EducationExperienceViewModel> GetList();
    }
}

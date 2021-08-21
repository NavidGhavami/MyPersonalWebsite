using System.Collections.Generic;

namespace _01_Query.Contract.EducationExperience
{
    public interface IEducationExperienceQuery
    {
        List<EducationExperienceQueryModel> GetList();
    }
}

using System.Collections.Generic;

namespace _01_Query.Contract.Skills
{
    public interface ISkillQuery
    {
        List<SkillQueryModel> GetSkills();

    }
}

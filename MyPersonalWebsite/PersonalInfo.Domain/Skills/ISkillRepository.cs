using System.Collections.Generic;
using _0_Framework.Domain;
using PersonalInfoManagement.Application.Contract.Skill;

namespace PersonalInfo.Domain.Skills
{
    public interface ISkillRepository : IRepository<long,Skills>
    {
        EditSkill GetDetails(long id);
        List<SkillViewModel> GetList();
    }
}

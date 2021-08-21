using System.Collections.Generic;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.Skill
{
    public interface ISkillApplication
    {
        OperationResult Create(CreateSkill command);
        OperationResult Edit(EditSkill command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditSkill GetDetails(long id);
        List<SkillViewModel> GetList();
    }
}

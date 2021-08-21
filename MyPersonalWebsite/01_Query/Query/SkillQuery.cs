using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Skills;
using PersonalInfoManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class SkillQuery : ISkillQuery
    {
        private readonly PersonalInfoContext _personalInfoContext;

        public SkillQuery(PersonalInfoContext personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public List<SkillQueryModel> GetSkills()
        {
            return _personalInfoContext.Skills
                .Where(x => x.IsRemoved == false)
                .Select(x => new SkillQueryModel
                {
                    SkillName = x.SkillName,
                    ShowOrder = x.ShowOrder,
                    SkillPercent = x.SkillPercent,
                    Description = x.Description,
                    

                }).OrderByDescending(x => x.ShowOrder).ToList();
        }
    }
}

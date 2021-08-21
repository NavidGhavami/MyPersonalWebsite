using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using PersonalInfo.Domain.Skills;
using PersonalInfoManagement.Application.Contract.Skill;

namespace PersonalInfoManagement.Infrastructure.EFCore.Repository
{
    public class SkillRepository : RepositoryBase<long, Skills>, ISkillRepository
    {
        private readonly PersonalInfoContext _personalInfoContext;
        public SkillRepository(PersonalInfoContext personalInfoContext) : base(personalInfoContext)
        {
            _personalInfoContext = personalInfoContext;
        }

        public EditSkill GetDetails(long id)
        {
            return _personalInfoContext.Skills
                .Select(x => new EditSkill
                {
                    Id = x.Id,
                    SkillName = x.SkillName,
                    SkillPercent = x.SkillPercent,
                    Description = x.Description,
                    ShowOrder = x.ShowOrder

                }).OrderByDescending(x => x.Id).FirstOrDefault(x => x.Id == id);
        }

        public List<SkillViewModel> GetList()
        {
            return _personalInfoContext.Skills.Select(x => new SkillViewModel
            {
                Id = x.Id,
                SkillName = x.SkillName,
                SkillPercent = x.SkillPercent,
                Description = x.Description,
                ShowOrder = x.ShowOrder,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()

            }).ToList();
        }
    }


}

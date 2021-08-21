using System.Collections.Generic;
using _0_Framework.Application;
using PersonalInfo.Domain.Skills;
using PersonalInfoManagement.Application.Contract.Skill;

namespace PersonalInfoManagement.Application
{
    public class SkillApplication : ISkillApplication
    {
        private readonly ISkillRepository _skillRepository;

        public SkillApplication(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public OperationResult Create(CreateSkill command)
        {
            var operation = new OperationResult();

            var skill = new Skills(command.SkillName, command.SkillPercent, command.Description,command.ShowOrder);

            _skillRepository.Create(skill);
            _skillRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditSkill command)
        {
            var operation = new OperationResult();
            var skill = _skillRepository.Get(command.Id);

            if (skill == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            skill.Edit(command.SkillName, command.SkillPercent, command.Description, command.ShowOrder);

            _skillRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var jobExperience = _skillRepository.Get(id);

            if (jobExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            jobExperience.Remove();

            _skillRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var jobExperience = _skillRepository.Get(id);

            if (jobExperience == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            jobExperience.Restore();

            _skillRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditSkill GetDetails(long id)
        {
            return _skillRepository.GetDetails(id);
        }

        public List<SkillViewModel> GetList()
        {
            return _skillRepository.GetList();
        }
    }
}

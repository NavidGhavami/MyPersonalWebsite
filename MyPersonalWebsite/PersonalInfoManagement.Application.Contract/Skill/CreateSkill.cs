using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace PersonalInfoManagement.Application.Contract.Skill
{
    public class CreateSkill
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string SkillName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string SkillPercent { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public int ShowOrder { get; set; }
    }
}

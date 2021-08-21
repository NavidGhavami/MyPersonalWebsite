namespace PersonalInfoManagement.Application.Contract.Skill
{
    public class CreateSkill
    {
        public string SkillName { get; set; }
        public string SkillPercent { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
    }
}

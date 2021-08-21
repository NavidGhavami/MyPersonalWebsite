namespace PersonalInfoManagement.Application.Contract.Skill
{
    public class SkillViewModel
    {
        public long Id { get; set; }
        public string SkillName { get; set; }
        public string SkillPercent { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate  { get; set; }
    }
}

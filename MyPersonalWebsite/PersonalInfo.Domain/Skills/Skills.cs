using _0_Framework.Domain;

namespace PersonalInfo.Domain.Skills
{
    public class Skills : EntityBase
    {
        public string SkillName { get; private set; }
        public string SkillPercent { get; private set; }
        public string Description { get; private set; }
        public int ShowOrder { get; private set; }
        public bool IsRemoved { get; private set; }

        public Skills(string skillName, string skillPercent, string description, int showOrder)
        {
            SkillName = skillName;
            SkillPercent = skillPercent;
            Description = description;
            ShowOrder = showOrder;
            IsRemoved = false;
        }

        public void Edit(string skillName, string skillPercent, string description, int showOrder)
        {
            SkillName = skillName;
            SkillPercent = skillPercent;
            Description = description;
            ShowOrder = showOrder;
            Description = description;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}

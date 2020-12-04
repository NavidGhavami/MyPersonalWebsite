using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models
{

    public class Experience
    {
        public long ExID { get; set; }
        public string ExYear { get; set; }
        public string ExTitle { get; set; }
        public string ExDescription { get; set; }



        public Experience(int exId, string exYear, string exTitle, string exDescription)
        {
            ExID = exId;
            ExYear = exYear;
            ExTitle = exTitle;
            ExDescription = exDescription;
        }
    }
    public class Education
    {
        public long EdID { get; set; }
        public string EdYear { get; set; }
        public string EdTitle { get; set; }
        public string EdDescription { get; set; }



        public Education(int edId, string edYear, string edTitle, string edDescription)
        {
            EdID = edId;
            EdYear = edYear;
            EdTitle = edTitle;
            EdDescription = edDescription;
        }
    }

    public class WorkSkills
    {
        public long SkillsID { get; set; }
        public string SkillsName { get; set; }
        public int SkillPercentage { get; set; }

        public WorkSkills(long skillsId, string skillsName, int skillPercentage)
        {
            SkillsID = skillsId;
            SkillsName = skillsName;
            SkillPercentage = skillPercentage;
        }
    }
    public class OveralSkills
    {
        public long SkillsID { get; set; }
        public string SkillsName { get; set; }
        public int SkillPercentage { get; set; }

        public OveralSkills(long skillsId, string skillsName,int skillPercentage)
        {
            SkillsID = skillsId;
            SkillsName = skillsName;
            SkillPercentage = skillPercentage;
        }
    }

}

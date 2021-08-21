using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Query.Contract.Skills
{
    public class SkillQueryModel
    {
        public long Id { get; set; }
        public string SkillName { get; set; }
        public string SkillPercent { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
        public bool IsRemoved { get; set; }
    }
}

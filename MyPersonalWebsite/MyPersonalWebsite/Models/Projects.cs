using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models
{
    public class Projects
    {
        public long ProjectID { get; set; }
        public string ProjectCompany { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectImage { get; set; }

        public Projects(long projectId, string projectCompany, string projectCategory, string projectImage)
        {
            ProjectID = projectId;
            ProjectCompany = projectCompany;
            ProjectCategory = projectCategory;
            ProjectImage = projectImage;
        }
    }
}

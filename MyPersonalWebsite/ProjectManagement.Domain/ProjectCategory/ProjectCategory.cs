using System.Collections.Generic;
using _0_Framework.Domain;

namespace ProjectManagement.Domain.ProjectCategory
{
    public class ProjectCategory : EntityBase
    {
        public string Name { get; private set; }
        public List<Project.Project> Projects { get; private set; }


        public ProjectCategory()
        {
            Projects = new List<Project.Project>();
        }

        public ProjectCategory(string name)
        {
            Name = name;
        }

        public void Edit(string name)
        {
            Name = name;
        }
    }
}

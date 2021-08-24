using System.Collections.Generic;
using _01_Query.Contract.Project;

namespace _01_Query.Contract.ProjectCategory
{
    public class ProjectCategoryQueryModel
    {
        public string Name { get; set; }
        public List<ProjectQueryModel> Projects { get; set; }
    }
}

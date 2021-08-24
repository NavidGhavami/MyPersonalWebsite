using System.Collections.Generic;
using _01_Query.Contract.Project;
using _01_Query.Contract.ProjectCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyProjectsModel : PageModel
    {
        public List<ProjectQueryModel> Projects;

        private readonly IProjectQuery _projectQuery;
        private readonly IProjectCategoryQuery _projectCategoryQuery;

        public MyProjectsModel(IProjectQuery projectQuery, IProjectCategoryQuery projectCategoryQuery)
        {
            _projectQuery = projectQuery;
            _projectCategoryQuery = projectCategoryQuery;
        }

        public void OnGet()
        {
            Projects = _projectQuery.GetProjects();
        }
    }
}

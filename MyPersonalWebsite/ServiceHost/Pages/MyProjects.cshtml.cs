using System.Collections.Generic;
using _01_Query.Contract.Project;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyProjectsModel : PageModel
    {
        public List<ProjectQueryModel> Projects;

        private readonly IProjectQuery _projectQuery;

        public MyProjectsModel(IProjectQuery projectQuery)
        {
            _projectQuery = projectQuery;
            
        }

        public void OnGet()
        {
            Projects = _projectQuery.GetProjects();
        }
    }
}

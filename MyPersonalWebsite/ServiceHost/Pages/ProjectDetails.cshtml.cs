using System.Collections.Generic;
using _01_Query.Contract.Project;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProjectDetailsModel : PageModel
    {
        private readonly IProjectQuery _projectQuery;

        public ProjectQueryModel ProjectDetails;
        public List<ProjectQueryModel> ProjectImages;

        public ProjectDetailsModel(IProjectQuery projectQuery)
        {
            _projectQuery = projectQuery;
        }

        public void OnGet(string id)
        {
            ProjectDetails = _projectQuery.GetProjectDetails(id);
        }
    }
}

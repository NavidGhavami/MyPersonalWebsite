using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ServiceHost.Areas.Administration.Pages.Project.Projects
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }

        public List<ProjectViewModel> Projects;
        public SelectList ProjectCategory;
        private readonly IProjectApplication _projectApplication;
        private readonly IProjectCategoryApplication _projectCategoryApplication;


        public IndexModel(IProjectApplication projectApplication,
            IProjectCategoryApplication projectCategoryApplication)
        {
            _projectApplication = projectApplication;
            _projectCategoryApplication = projectCategoryApplication;
        }

        public void OnGet()
        {
            Projects = _projectApplication.GetProjects();
            
        }

    }
}

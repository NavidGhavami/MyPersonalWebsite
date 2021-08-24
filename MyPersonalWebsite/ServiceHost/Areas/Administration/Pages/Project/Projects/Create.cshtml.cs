using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ServiceHost.Areas.Administration.Pages.Project.Projects
{
    public class CreateModel : PageModel
    {
        public SelectList ProjectCategories;
        public CreateProject Command;

        private readonly IProjectApplication _projectApplication;
        private readonly IProjectCategoryApplication _projectCategoryApplication;

        public CreateModel(IProjectCategoryApplication projectCategoryApplication, IProjectApplication projectApplication)
        {
            _projectCategoryApplication = projectCategoryApplication;
            _projectApplication = projectApplication;
        }

        public void OnGet()
        {
            ProjectCategories = new SelectList(_projectCategoryApplication
                .GetProjectCategory(), "Id", "Name");
        }

        public IActionResult OnPost(CreateProject command)
        {
            var project = _projectApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}

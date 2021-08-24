using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Application.Contract.Project;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ServiceHost.Areas.Administration.Pages.Project.Projects
{
    public class EditModel : PageModel
    {
        public SelectList ProjectCategories;
        public EditProject Command;

        private readonly IProjectApplication _projectApplication;
        private readonly IProjectCategoryApplication _projectCategoryApplication;

        public EditModel(IProjectApplication projectApplication, IProjectCategoryApplication projectCategoryApplication)
        {
            _projectApplication = projectApplication;
            _projectCategoryApplication = projectCategoryApplication;
        }


        public void OnGet(long id)
        {
            Command = _projectApplication.GetDetails(id);
            ProjectCategories = new SelectList(_projectCategoryApplication
                .GetProjectCategory(), "Id", "Name");
        }

        public IActionResult OnPost(EditProject command)
        {
            var project = _projectApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}

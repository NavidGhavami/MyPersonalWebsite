using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManagement.Application.Contract.ProjectCategory;

namespace ServiceHost.Areas.Administration.Pages.Project.ProjectCategory
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public List<ProjectCategoryViewModel> ProjectCategory;

        private readonly IProjectCategoryApplication _projectCategoryApplication;

        public IndexModel(IProjectCategoryApplication projectCategoryApplication)
        {
            _projectCategoryApplication = projectCategoryApplication;
        }

        public void OnGet()
        {
            ProjectCategory = _projectCategoryApplication.GetProjectCategory();
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProjectCategory();
            return Partial("./Create", command);

        }

        public JsonResult OnPostCreate(CreateProjectCategory command)
        {
            var result = _projectCategoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var projectCategory = _projectCategoryApplication.GetDetails(id);
            return Partial("Edit", projectCategory);
        }

        public JsonResult OnPostEdit(EditProjectCategory command)
        {
            var result = _projectCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}

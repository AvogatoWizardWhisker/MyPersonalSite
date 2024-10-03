using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPersonalSite.Pages
{
    public class ProjectsModel : PageModel
    {
        public readonly ILogger<ProjectsModel> _Logger;

        public ProjectsModel(ILogger<ProjectsModel> logger)
        {
            _Logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

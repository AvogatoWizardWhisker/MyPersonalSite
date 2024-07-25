using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPersonalSite.Pages
{
    public class ToolsModel : PageModel
    {
        private readonly ILogger<ToolsModel> _logger;

        public ToolsModel(ILogger<ToolsModel> logger)
        {
            _logger= logger;
        }

        public void OnGet()
        {
        }
    }
}

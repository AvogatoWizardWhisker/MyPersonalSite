using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPersonalSite.Pages
{
    public class SetupsModel : PageModel
    {
        public readonly ILogger<SetupsModel> _Logger;

        public SetupsModel(ILogger<SetupsModel> logger)
        {
            _Logger = logger;
        }
    
        public void OnGet()
        {
        
        }
    }    
}
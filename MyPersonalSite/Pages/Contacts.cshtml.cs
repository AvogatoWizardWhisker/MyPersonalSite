using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPersonalSite.Pages
{
    public class ContactsModel : PageModel
    {
        public readonly ILogger<ContactsModel> _Logger;

        public ContactsModel(ILogger<ContactsModel> logger)
        {
            _Logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages.Authorization
{
    [Authorize(Roles="client")]
    public class ClientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;

namespace WebApplication2.Pages.Authorization
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;

        //Dette er vores bindeled til vores cshtml fil som kan være null
        public ApplicationUser? appUser;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public async void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            // Gemmer vores detajler i appUser af type ApplicationUser( Dette er vores bindeled til vores cshtml fil)
            appUser = task.Result;

        }
    }
}

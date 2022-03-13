using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.StudentProfile;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.ViewComponents
{
    public class AdminHeaderViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminHeaderViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser userI = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
            var user = _userManager.Users.Where(u => u.UserName == userI.UserName).Select(c => new ProfileVM
            {

                FullName = c.FullName,



            }).FirstOrDefault();
            return View(user);


        }
    }
}

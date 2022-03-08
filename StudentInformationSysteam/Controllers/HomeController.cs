using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentIformationSysteam.Core.Models;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)

        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser userI = await _userManager.GetUserAsync(User);
            ViewBag.UserName=userI.FullName;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public HomeController(UserManager<AppUser> userManager,AppDbContext context)

        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AppUser userI = await _userManager.GetUserAsync(User);
            ViewBag.UserName=userI.FullName;
            ViewBag.Notifications = _context.Notifications.OrderByDescending(n=>n.Id).Take(5).ToList();
            return View();
        }
    }
}

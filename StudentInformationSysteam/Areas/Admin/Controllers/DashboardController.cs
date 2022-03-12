using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
      

        public DashboardController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
          
        }
        public IActionResult Index()
        {

            ViewBag.UserStudent = _context.UserRoles.Where(x => x.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Count(); 
            ViewBag.TeacherCount = _context.UserRoles.Where(x => x.RoleId == "b7fa0d73-4cc0-401e-8d91-60485688424e").Count();
            ViewBag.SubjectCount = _context.Subjects.Count();

            return View();
        }
    }
}

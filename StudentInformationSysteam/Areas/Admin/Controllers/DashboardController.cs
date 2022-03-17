using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.StudentProfile;
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
        public async Task<IActionResult> Index()
        {

            ViewBag.UserStudent = _context.UserRoles.Where(x => x.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Count(); 
            ViewBag.TeacherCount = _context.UserRoles.Where(x => x.RoleId == "dcd64b81-e06e-41e3-8da5-0d1bb45cc2bd").Count();
            ViewBag.SubjectCount = _context.Subjects.Count();
            ViewBag.GroupCount = _context.Groups.Count();
            ViewBag.FacultyCount = _context.Faculties.Count();
            ViewBag.SpecalityCount = _context.Specialities.Count();

            AppUser userI = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
            var user = _userManager.Users.Where(u => u.UserName == userI.UserName).Select(c => new ProfileVM
            {

                FullName = c.FullName,



            }).FirstOrDefault();

            return View(user);
        }
    }
}

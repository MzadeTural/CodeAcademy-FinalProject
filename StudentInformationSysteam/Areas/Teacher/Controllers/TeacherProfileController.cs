using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class TeacherProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TeacherProfileController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;

            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser userI = await _userManager.GetUserAsync(User);

            AppUser userDetails = await _context.Users
                                                .Include(u => u.Gender)

                                                .FirstOrDefaultAsync(n => n.Id == userI.Id);


            return View(userDetails);

        }
    }
}

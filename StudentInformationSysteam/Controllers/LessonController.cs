using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class LessonController : Controller
    {
        public AppDbContext _context { get; }
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public RoleManager<IdentityRole> _roleManager;

        public LessonController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AppUser userI = await _userManager.GetUserAsync(User);

            AppUser userDetails = await _context.Users
               .Include(ab => ab.UserGroups)
               .ThenInclude(b => b.Group)           
               .ThenInclude(b => b.GroupSubjects)              
              .ThenInclude(b=>b.Subject)
               .FirstOrDefaultAsync(n => n.Id == userI.Id);

          
            return View(userDetails);
           
        }
    }
}

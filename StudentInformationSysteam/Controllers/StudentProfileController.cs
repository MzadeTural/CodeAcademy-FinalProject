using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.StudentProfile;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class StudentProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public StudentProfileController( AppDbContext context,UserManager<AppUser> userManager)

        {
            _context = context;
            _userManager = userManager;
        }
       
        public async Task<IActionResult> Index()
        {        
            AppUser userI = await _userManager.GetUserAsync(User);
                   
            AppUser bookDetails = await _context.Users
               .Include(ab => ab.UserGroups)
               .ThenInclude(b => b.Group)
               .ThenInclude(b=>b.Faculty)
               .Include(u=>u.Course)
             
               .FirstOrDefaultAsync(n => n.Id == userI.Id);

         
            return View(bookDetails);


           
        }
    }
}

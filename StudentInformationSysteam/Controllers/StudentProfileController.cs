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
        public async Task<AppUser> GetAuthorByIdAsync(string id)
        {
            var bookDetails = await _context.Users
                .Include(ab => ab.UserGroups)
                .ThenInclude(b => b.Group)
                .FirstOrDefaultAsync(n => n.Id == "2a68892b-6c94-4501-9abd-25c170c66184");
            return bookDetails;
        }
        public async Task<IActionResult> Index()
        {
           
            AppUser userI = await _userManager.GetUserAsync(User);
            var user = _userManager.Users.Where(u => u.UserName == userI.UserName).Select(c => new ProfileVM
            {
                FateherName=c.FatherName,
                FullName = c.FullName,
               Course=c.Course.Name,
               Gender=c.Gender,
              UserName =c.UserName,
             



            }).FirstOrDefault();
            return View(user);


           
        }
    }
}

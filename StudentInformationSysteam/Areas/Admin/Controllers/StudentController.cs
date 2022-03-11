using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.Student;
using StudnetInformationSysteam.Data.DAL;
using System;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public StudentController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
          
            return View();
        }

        public async Task<IActionResult> AddStudent()
        {
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStudent(CreateVM createVM)
        {
            if (!ModelState.IsValid) return View();
            var IsExist = await _userManager.FindByNameAsync(createVM.UserName);
            if (IsExist!=null)
            {
                ModelState.AddModelError("Name", "This User already exist");
                return RedirectToAction(nameof(Index));
            }
            AppUser newUser = new AppUser
            {
               FullName=createVM.FullName,
               FatherName=createVM.FatherName,
               UserName=createVM.UserName,
               GenderId=createVM.GenderId,
               CourseId=createVM.CourseId,             

            };
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.TeacherVMs;
using StudnetInformationSysteam.Data.DAL;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
      [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TeacherController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: TeacherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeacherController/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Genders = new SelectList(await _context.Genders.ToListAsync(), "Id", "Name");
            return View();

        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherCreateVM teacherCreate)
        {
            if (!ModelState.IsValid) return View();
            var IsExist = await _userManager.FindByNameAsync(teacherCreate.UserName);
            if (IsExist != null)
            {
                ModelState.AddModelError("Name", "This User already exist");
                return RedirectToAction(nameof(Index));
            }
            AppUser newUser = new AppUser
            {
                FullName = teacherCreate.FullName,
                FatherName = teacherCreate.FatherName,
                UserName = teacherCreate.UserName,
                GenderId = teacherCreate.GenderId,
               
                Email = teacherCreate.Email,
                Identifier = teacherCreate.Identifier,

            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, "Teacher123@");
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(teacherCreate);
            }
            await _userManager.AddToRoleAsync(newUser, UserRoles.Teacher.ToString());

            return RedirectToAction(nameof(Create));
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeacherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

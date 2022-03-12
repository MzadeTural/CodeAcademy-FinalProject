using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.Group;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GroupController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public GroupController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        // GET: FroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FroupController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "Id", "Name");
            ViewBag.Faculty = new SelectList(await _context.Faculties.ToListAsync(), "Id", "Name");
            return View();
        }

        // POST: FroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(GroupCreateVM groupCreate)
        {
            if (!ModelState.IsValid) return View();
            bool IsExist = _context.Groups
                                 .Any(c => c.Name.ToLower().Trim() == groupCreate.Name.ToLower().Trim());
            if (IsExist)
            {
                ModelState.AddModelError("Group Name", "This category already exist");
                return View();
            }

            Group group = new Group
            {
                Name = groupCreate.Name,
                FacultyId = groupCreate.FacultyId,
                CourseId = groupCreate.CourseId,
            };

            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Create));

        }

        // GET: FroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FroupController/Edit/5
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

        // GET: FroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FroupController/Delete/5
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

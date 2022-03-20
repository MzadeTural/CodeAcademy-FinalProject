using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GroupSubjectController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public GroupSubjectController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: GroupSubjectController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GroupSubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GroupSubjectController/Create
        public IActionResult AddSubject()
        {
            ViewBag.GroupList = new SelectList(_context.Subjects.ToList(), "Id", "Name");
            return View();
        }

        // POST: GroupSubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSubject(int id ,int [] SubjectIds)
        {
            foreach (var sbjId in SubjectIds)
            {

                GroupSubject subject = new GroupSubject
                {
                    GroupId=id,
                    SubjectId=sbjId
                };
                await _context.GroupSubjects.AddAsync(subject);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        // GET: GroupSubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GroupSubjectController/Edit/5
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

        // GET: GroupSubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GroupSubjectController/Delete/5
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    public class UserGroupController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManeger;

        public UserGroupController( AppDbContext context , UserManager<AppUser> userManager)
        {
            _context = context;
            _userManeger = userManager;
        }
        // GET: UserGroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserGroupController/Create
        public async Task<ActionResult> AddStudentToGroup()
        {
            //ViewBag.Students = new SelectList(await _context.UserRoles.Where(x => x.RoleId == "f00cc3f4-d208-4597-9179-ba035b34c6b6")

            //                                                           .ToListAsync(), "Id", "Name");
            //ViewBag.Students = new SelectList(await _userManeger.Users.Include(u=>u.AppUserRoles).Where(x => x. == "f00cc3f4-d208-4597-9179-ba035b34c6b6")

            //                                                          .ToListAsync(), "Id", "Name");
            return View();
        }

        // POST: UserGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudentToGroup(IFormCollection collection)
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

        // GET: UserGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserGroupController/Edit/5
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

        // GET: UserGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserGroupController/Delete/5
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

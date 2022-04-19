using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.SubjectVMs;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubjectController : Controller
    {
        private readonly AppDbContext _context;

        public SubjectController(AppDbContext context)
        {
            _context = context;
        }
        // GET: SubjectController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubjectCreateVM subjectCreate)
        {
            if (!ModelState.IsValid) return View();
            bool IsExist = _context.Subjects
                                 .Any(c => c.Name.ToLower().Trim() == subjectCreate.Name.ToLower().Trim());
            if (IsExist)
            {
                ModelState.AddModelError("Name", "This subject already exist");
                return View(nameof(Create));
            }
            Subject sibject = new Subject
            {

                Name = subjectCreate.Name
            };
            await _context.Subjects.AddAsync(sibject);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Subject Created";
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteSubjectFromGroup(int sbjId,int groupId)
        {


            var classSubject = _context.GroupSubjects.Where(x => x.SubjectId == sbjId && x.GroupId == groupId).ToList();


            foreach (var item in classSubject)
            {
                _context.GroupSubjects.RemoveRange(item);
            }

            List<string> getClassToUserIds = _context.UserGroups
                                                 .Where(a => a.GroupId  == groupId)
                                                 .Select(b => b.AppUserId)
                                                 .Distinct()
                                                 .ToList();
            var userTeacherRoleIds =  _context.UserRoles
                                             .Where(a => a.RoleId == "7587f730-8dfe-4a9f-9a86-4797d2a117ac")
                                             .Select(b => b.UserId)
                                             .Distinct()
                                             .ToList();
            List<string> getStudentToUserIds = _context.UserRoles
                                             .Where(a => a.RoleId == "c1c95c2b-81e5-45d9-8b73-2a3ddbf1b9f0")
                                             .Select(b => b.UserId)
                                             .Distinct()
                                             .ToList();
            var getClassToStudent = _context.Users
                                          .Where(a => getClassToUserIds.Any(c => c == a.Id) && getStudentToUserIds.Any(c => c == a.Id))
                                          .Select(i => i.Id)
                                          .ToList();
            var getClassToTeacher = _context.Users
                                          .Where(a => getClassToUserIds.Any(c => c == a.Id) && userTeacherRoleIds.Any(c => c == a.Id))
                                          .Select(i => i.Id)
                                          .ToList();
            foreach (var teacherId in getClassToTeacher)
            {
                var thisClassTeacherRela = _context.UserGroups.Where(i => i.AppUserId == teacherId && i.GroupId == groupId).ToList();
                foreach (var item in thisClassTeacherRela)
                {
                    _context.UserGroups.RemoveRange(item);
                }
            }
            foreach (var stuId in getClassToStudent)
            {
                var thisClassStudentSubRela = _context.SubjectTeachers.Where(i => i.AppUserId == stuId && i.SubjectId == sbjId).ToList();
                foreach (var item in thisClassStudentSubRela)
                {
                    _context.SubjectTeachers.RemoveRange(item);
                }
            }
          


            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Dashboard");
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
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

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectController/Delete/5
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

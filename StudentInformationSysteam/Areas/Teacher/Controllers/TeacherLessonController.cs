using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.TeacherLesson;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{         [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class TeacherLessonController : Controller
    {
        public AppDbContext _context { get; }
        private UserManager<AppUser> _userManager;


        public TeacherLessonController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;


            _context = context;
        }
        // GET: TeacherLessonController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeacherLessonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeacherLessonController/Create
        public async Task<IActionResult> Create(int groupId, int sbjId)
        {



            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();

            var userFromGroupId = _context.UserGroups.Where(i => i.GroupId == groupId).Select(i => i.AppUserId).ToList();
            var userFromSubject = _context.SubjectTeachers.Where(i => i.SubjectId == sbjId).Select(i => i.AppUserId).ToList();

            var AppUsers = _context.Users
                                       .Where(a => userFromGroupId
                                       .Any(c => c == a.Id) && userFromSubject
                                       .Any(c => c == a.Id) && userids
                                       .Any(c => c == a.Id)).ToList();

            ViewBag.Students = AppUsers;
            ViewBag.LessonTypes = new SelectList(await _context.LessonTypes.ToListAsync(), "Id", "Name");
          


            return View();
           
        }

        // POST: TeacherLessonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LessonCreateVM lessonCreate,int sbjId,int groupId)
        {
            int i = 0;
          
            foreach (var a in lessonCreate.AppUserId)
            {

                Lesson lesson = new Lesson
                {
                    AppUserId = a,
                    SubjectId = sbjId,
                    Score = lessonCreate.Score[i],
                    Name = lessonCreate.Name,
                    LessonTypeId = lessonCreate.LessonTypeId

                };
                await _context.Lesssons.AddAsync(lesson);
                await _context.SaveChangesAsync();
                i++;
            }
           
            return RedirectToAction("Index", "TeacherSubject", new { Id = groupId, SbjId= sbjId });
        }




        // GET: TeacherLessonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeacherLessonController/Edit/5
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

        // GET: TeacherLessonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeacherLessonController/Delete/5
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

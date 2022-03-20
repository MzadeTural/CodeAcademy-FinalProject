using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.TeacherSubject;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class TeacherSubjectController : Controller
    {
        public AppDbContext _context { get; }
        private UserManager<AppUser> _userManager;
       

        public TeacherSubjectController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
          

            _context = context;
        }
        // GET: SubjectController
        public async Task<IActionResult> Index()
        {
            AppUser userI = await _userManager.GetUserAsync(User);

            AppUser userDetails = await _context.Users
               .Include(ab => ab.UserGroups)
               .ThenInclude(b => b.Group)
               .ThenInclude(b => b.GroupSubjects)
              .ThenInclude(b => b.Subject)
               .FirstOrDefaultAsync(n => n.Id == userI.Id);


            return View(userDetails);
           
        }

        // GET: SubjectController/Details/5
        public async Task<IActionResult> Details(int id,int sbjId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            List<string> getGroupToUserIds = _context.UserGroups
                                                 .Where(a => a.GroupId == id)
                                                 .Select(b => b.AppUserId)
                                                 .Distinct()
                                                 .ToList();
            List<string> getSubjectToUserIds = _context.SubjectTeachers
                                               .Where(a => a.SubjectId == sbjId)
                                               .Select(b => b.AppUserId)
                                               .Distinct()
                                               .ToList();
            List<string> getExamToUserIds = _context.UserExams
                                               .Where(a => a.SubjectId == sbjId)
                                               .Select(b => b.AppUserId)
                                               .Distinct()
                                               .ToList();
           
            List<int> documentGroupId = _context.Documents
                                               .Where(a => a.GroupId == id)
                                               .Select(b => b.Id)
                                               .Distinct()
                                               .ToList();
            List<int> documenSubjectId = _context.Documents
                                               .Where(a => a.SubjectId == sbjId)
                                               .Select(b => b.Id)
                                               .Distinct()
                                               .ToList();
            List<string> getStudentToUserIds = _context.UserRoles.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();

            var getClassToStudent = _context.Users
                                          .Where(a => getGroupToUserIds.Any(c => c == a.Id) && getStudentToUserIds.Any(c => c == a.Id) && getExamToUserIds.Any(c => c == a.Id) && getSubjectToUserIds.Any(c => c == a.Id)).Include(i => i.UserExams).ThenInclude(i => i.Exam).ToList();
        
            var getClassToStudents = _context.Users                                        
                .Where(a => getGroupToUserIds.Any(c => c == a.Id)).Include(i => i.UserExams).ThenInclude(i => i.Exam).ToList();
            //////
               var lessons = _context.Lesssons.Where(a => getGroupToUserIds.Any(c => c == a.AppUserId) && a.SubjectId == sbjId).Include(x => x.AppUser).Include(s=>s.LessonType).ToList();



            ////
            SubjectDetailVM subjectDetail = new SubjectDetailVM
            {
                Lessons= lessons,
                Documents =_context.Documents.Where(a => documentGroupId.Any(c => c == a.Id) && documenSubjectId.Any(c => c == a.Id) ).ToList()

              };
            
            ViewBag.GroupId = id;
            ViewBag.SubjectId = sbjId;

            return View(subjectDetail);
          
        }
        public async Task<IActionResult> AddEvaluation(int id,int sbjId)
        {
            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();

            var userFromGroupId = _context.UserGroups.Where(i => i.GroupId == id).Select(i => i.AppUserId).ToList();
            var userFromSubject = _context.SubjectTeachers.Where(i => i.SubjectId == sbjId).Select(i => i.AppUserId).ToList();

            var AppUsers = _context.Users
                                       .Where(a => userFromGroupId
                                       .Any(c => c == a.Id) && userFromSubject
                                       .Any(c => c == a.Id) && userids
                                       .Any(c => c == a.Id)).ToList();

            ViewBag.Teachers = AppUsers;
             ViewBag.ExamType = _context.SubjectExams.Where(x => x.SubjectId == sbjId).Select(i => i.Exam).ToList();
         //   ViewBag.ExamType = new SelectList(await _context.Courses.ToListAsync(), "Id", "Name");
            return View(AppUsers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEvaluation(int examId, string[] studentIds, double[] scoors)
        {
            int i = 0;
            foreach (var a in studentIds)
            {

                UserExam userEx = new UserExam
                {
                    AppUserId = a,
                    ExamId = examId,
                    Scoor = scoors[i]

                };
                await _context.UserExams.AddAsync(userEx);
                await _context.SaveChangesAsync();
                i++;
            }


            return RedirectToAction("Index","TeacherSubject");
        }
       























        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

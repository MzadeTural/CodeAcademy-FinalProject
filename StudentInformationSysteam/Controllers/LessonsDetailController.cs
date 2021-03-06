using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.TeacherSubject;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class LessonsDetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;

        public LessonsDetailController(AppDbContext context,UserManager<AppUser> userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult DownloadFile(int id)
        {
            // Since this is just and example, I am using a local file located inside wwwroot
            // Afterwards file is converted into a stream
            var userFromSubject = _context.Documents.Where(i => i.Id == id).Select(i => i.FilePath).FirstOrDefault();

            string resultPath = Path.Combine("assets/document", userFromSubject);
            var path = Path.Combine(_env.WebRootPath, resultPath);
            var fs = new FileStream(path, FileMode.Open);

            // Return the file. A byte array can also be used instead of a stream
            return File(fs, "assets/document", userFromSubject);
        }
        public async Task<IActionResult> Index(int sbjId,int id)
        {

            var currentUser = await _userManager.GetUserAsync(User);


            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "dcd64b81-e06e-41e3-8da5-0d1bb45cc2bd").Select(b => b.UserId).Distinct().ToList();
            List<string> userSbj = _context.SubjectTeachers.Where(a => a.SubjectId == sbjId).Select(b => b.AppUserId).Distinct().ToList();
            List<string> sbjTeacher = _context.UserGroups.Where(a => a.GroupId == id).Select(b => b.AppUserId).Distinct().ToList();
            //  var abc=_context.UserGroups
            var techer = _context.Users.Where(a => userids
                                     .Any(c => c == a.Id) && userSbj
                                     .Any(c => c == a.Id) && sbjTeacher
                                     .Any(c => c == a.Id)).ToList();



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
           // var lessons = _context.Lesssons.Where(a => getGroupToUserIds.Any(c => c == a.AppUserId) && a.SubjectId == sbjId).Include(x => x.AppUser).Include(s => s.LessonType).ToList();

            var lessons = await _context.Lesssons.Where(s => s.AppUserId == currentUser.Id && s.SubjectId== sbjId).Include(l => l.LessonType).ToListAsync();

            ////
            SubjectDetailVM subjectDetail = new SubjectDetailVM
            {
                Lessons = lessons,
                Teachers= techer,
                Documents = _context.Documents.Where(a => documentGroupId.Any(c => c == a.Id) && documenSubjectId.Any(c => c == a.Id)).ToList()

            };

            ViewBag.GroupId = id;
            ViewBag.SubjectId = sbjId;

            return View(subjectDetail);
        }
    }
}

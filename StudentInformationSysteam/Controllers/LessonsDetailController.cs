using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.TeacherSubject;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class LessonsDetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public LessonsDetailController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int sbjId,int id)
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
           // var lessons = _context.Lesssons.Where(a => getGroupToUserIds.Any(c => c == a.AppUserId) && a.SubjectId == sbjId).Include(x => x.AppUser).Include(s => s.LessonType).ToList();

            var lessons = await _context.Lesssons.Where(s => s.AppUserId == currentUser.Id).Include(l => l.LessonType).ToListAsync();

            ////
            SubjectDetailVM subjectDetail = new SubjectDetailVM
            {
                Lessons = lessons,
                Documents = _context.Documents.Where(a => documentGroupId.Any(c => c == a.Id) && documenSubjectId.Any(c => c == a.Id)).ToList()

            };

            ViewBag.GroupId = id;
            ViewBag.SubjectId = sbjId;

            return View(subjectDetail);
        }
    }
}

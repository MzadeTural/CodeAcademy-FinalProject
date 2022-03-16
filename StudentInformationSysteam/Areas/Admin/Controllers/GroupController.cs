using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.Validators.Group;
using StudentInformationSysteam.Business.ViewModel;
using StudentInformationSysteam.Business.ViewModel.Group;
using StudentInformationSysteam.Business.ViewModel.UserGroup;
using StudnetInformationSysteam.Data.DAL;
using System;
using System.Collections.Generic;
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
        public IActionResult GroupsTable(int id,int page = 1)
        {
            int count = 5;
            ViewBag.TakeCount = count;
            var Groups = _context.Groups
                                          .Include(g => g.Faculty)
                                            .Where(g => g.FacultyId == id)
                                            .Include(g => g.Course)
                                            . Skip((page - 1) * count)
                                              .Take(count)
                                           .ToList();



            var optionVm = GetGroupList(Groups);
            int pageCount = GetPageCount(count);
            Paginate<GroupInfoVM> model = new Paginate<GroupInfoVM>(optionVm, page, pageCount);
            //ViewBag.StudentCount = _context.UserGroups.Where(g => g.GroupId == 1).Count();
            return View(model);
        }
        // GET: FroupController
        public IActionResult Index(int id, int page = 1)
        {
            int count = 3;
            ViewBag.TakeCount = count;
            var Groups =  _context.Groups.Skip((page - 1) * count)
                                              .Take(count)
                                            .Include(g => g.Faculty)
                                            .Where(g => g.FacultyId == id)
                                            .Include(g => g.Course)
                                           .ToList();

            

            var optionVm = GetGroupList(Groups);
            int pageCount = GetPageCount(count);
           Paginate<GroupInfoVM> model = new Paginate<GroupInfoVM>(optionVm, page, pageCount);
            //ViewBag.StudentCount = _context.UserGroups.Where(g => g.GroupId == 1).Count();
            return View(model);
        }
        public IActionResult AddSubject(int id)
        {

           // List<string> userids = _context.gr.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();
            List<int> sbjIds = _context.GroupSubjects.Where(a => a.GroupId == 1).Select(b => b.SubjectId).Distinct().ToList();


            var subjects = _context.Subjects
                                      
                                        .Where(a => !sbjIds
                                        .Any(c => c == a.Id)).ToList();
            
            ViewBag.Subjects = subjects;
            return View();
        }

        // POST: GroupSubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSubject(int id, int[] SubjectIds)
        {
            foreach (var sbjId in SubjectIds)
            {

                GroupSubject subject = new GroupSubject
                {
                    GroupId = id,
                    SubjectId = sbjId
                };
                await _context.GroupSubjects.AddAsync(subject);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("GroupSubject", new { Id = id });
        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Groups.Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<GroupInfoVM> GetGroupList(List<Group> options)
        {
            List<GroupInfoVM> model = new List<GroupInfoVM>();
           
            foreach (var item in options)
            {
                var option = new GroupInfoVM

                {
                    Id=item.Id,
                    GroupName=item.Name,
                    Course=item.Course.Name,
                    FacultyName=item.Faculty.Name,
                   

                };
                model.Add(option);
            }
            return model;
        }

        // GET: FroupController/Details/5
        public ActionResult Details(int id)
        {
            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();
            List<string> usergrp = _context.UserGroups.Where(a => a.GroupId == id).Select(b => b.AppUserId).Distinct().ToList();

            StudentShowVM student = new StudentShowVM
            {
                AppUsers = _context.Users
                                         .Include(u=>u.Gender)
                                         .Include(u=>u.UserGroups)
                                         .ThenInclude(u=>u.Group)
                                         .Where(a => userids
                                         .Any(c => c == a.Id) && usergrp
                                         .Any(c => c == a.Id)).ToList()
            };
            return View(student);
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
                ModelState.AddModelError("Group Name", "This name already exist");
                return RedirectToAction(nameof(Create));
            }

            Group group = new Group
            {
                Name = groupCreate.Name,
                FacultyId = groupCreate.FacultyId,
                CourseId = groupCreate.CourseId,
            };

            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();
            ViewBag.Courses = new SelectList(await _context.Courses.ToListAsync(), "Id", "Name");
            ViewBag.Faculty = new SelectList(await _context.Faculties.ToListAsync(), "Id", "Name");
         
            return View(group);   

        }

        // GET: FroupController/Edit/5
        public IActionResult GroupSubject(int id)
        {
              
         //   List<int> userids = _context.Subjects.Where(a => a.sub == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();
            List<int> sbjId = _context.GroupSubjects.Where(a => a.GroupId == id).Select(b => b.SubjectId).Distinct().ToList();

            GroupSubjectVM subjects = new GroupSubjectVM
            {
                Subjects = _context.Subjects.Where(a => sbjId.Any(c => c == a.Id)).Include(s => s.SubjectTeachers).ToList(),

            };
            //var sbj=_context.Subjects.Include(s=>s.SubjectTeachers).Th
           
            return View(subjects);
        }
        public async Task<IActionResult> AddStudent(int id)
        {
            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "36f0a116-ef5a-49ad-8395-1d542cb45174").Select(b => b.UserId).Distinct().ToList();
            List<string> usergrp = _context.UserGroups.Where(a => a.GroupId != 0).Select(b => b.AppUserId).Distinct().ToList();


          var  AppUsers = _context.Users                                    
                                     .Where(a => userids
                                     .Any(c => c == a.Id) && !usergrp
                                     .Any(c => c == a.Id)).ToList();



            ViewBag.Students = AppUsers;
            ViewBag.Specality = new SelectList(await _context.Specialities.ToListAsync(), "Id", "Name");
            return View();

        }

            // POST: GroupSubjectController/Create
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStudent(int id, string[] StudentId)
        {
            foreach (var userId in StudentId)
            {

                UserGroup users = new UserGroup
                {
                    GroupId = id,
                    AppUserId = userId
                };
                await _context.UserGroups.AddAsync(users);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Details", new { Id = id });
        }
        public async Task<IActionResult> AddTeacherToSubject(int id)
        {
            List<string> userids = _context.UserRoles.Where(a => a.RoleId == "dcd64b81-e06e-41e3-8da5-0d1bb45cc2bd").Select(b => b.UserId).Distinct().ToList();
            List<string> usergrp = _context.SubjectTeachers.Where(a => a.SubjectId != id).Select(b => b.AppUserId).Distinct().ToList();


            var AppUsers = _context.Users
                                       .Where(a => userids
                                       .Any(c => c == a.Id) && !usergrp
                                       .Any(c => c == a.Id)).ToList();



            ViewBag.Teachers = AppUsers;
            ViewBag.Specality = new SelectList(await _context.Specialities.ToListAsync(), "Id", "Name");
            return View();
        }

        // POST: GroupController/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTeacherToSubject(int id,string [] teacherIds)
        {
            foreach (var tchId in teacherIds)
            {
                SubjectTeacher subjectTeacher = new SubjectTeacher
                {
                    SubjectId = id,
                    AppUserId = tchId

                };
                await _context.SubjectTeachers.AddAsync(subjectTeacher);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("GroupSubject", new { Id = id });

        }
    
        // GET: FroupController/Delete/5 
        public async Task<IActionResult> Delete(int id)
        {
            Group group = await _context.Groups.Where(c => c.IsDeleted == false && c.Id == id).FirstOrDefaultAsync();
            var classUserList = _context.Groups.Include(x => x.UserGroups).Select(x => x.UserGroups.Where(x => x.GroupId == id));
            var classSubjextList = _context.Subjects.Include(x => x.GroupSubjects).Select(x => x.GroupSubjects.Where(x => x.GroupId == id));
            if (group == null) return NotFound();
            foreach (var item in classUserList)
            {
                _context.UserGroups.RemoveRange(item);
            }
            foreach (var sbj in classSubjextList)
            {
                _context.GroupSubjects.RemoveRange(sbj);
            }

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();
            return RedirectToAction("GroupSubject");
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

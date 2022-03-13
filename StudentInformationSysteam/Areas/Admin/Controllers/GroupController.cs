using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
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
        // GET: FroupController
        public IActionResult Index(int id, int page = 1)
        {
            int count = 2;
            ViewBag.TakeCount = count;
            var Groups =  _context.Groups.Skip((page - 1) * count)
                                              .Take(count)
                                            .Include(g => g.Faculty)
                                            .Where(g => g.FacultyId == id)
                                            .Include(g => g.Course)
                                           .ToList();

            

            var optionVm = GetProductList(Groups);
            int pageCount = GetPageCount(count);
           Paginate<GroupInfoVM> model = new Paginate<GroupInfoVM>(optionVm, page, pageCount);
            //ViewBag.StudentCount = _context.UserGroups.Where(g => g.GroupId == 1).Count();
            return View(model);
        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Groups.Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<GroupInfoVM> GetProductList(List<Group> options)
        {
            List<GroupInfoVM> model = new List<GroupInfoVM>();
            foreach (var item in options)
            {
                var option = new GroupInfoVM

                {
                    Id=item.Id,
                    GroupName=item.Name,
                    Course=item.Course.Name,
                    FacultyName=item.Faculty.Name


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
                ModelState.AddModelError("Group Name", "This category already exist");
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

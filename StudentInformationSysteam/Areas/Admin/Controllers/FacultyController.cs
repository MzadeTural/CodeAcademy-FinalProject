using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel;
using StudentInformationSysteam.Business.ViewModel.FacultyVM;
using StudnetInformationSysteam.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FacultyController : Controller
    {
        private readonly AppDbContext _context;

        public FacultyController(AppDbContext context)
        {
            _context = context;
        }
        // GET: FacultyController
        public async Task<IActionResult> Index(int page = 1)
        {
            //int count = 6;
            //ViewBag.TakeCount = count;
            //var Faculties = await _context.Faculties
            //                                   .Include(f => f.Groups)
            //                                   .ToListAsync();


            //var optionVm = GetFacultyList(Faculties);
            //int pageCount = GetPageCount(count);
            //Paginate<FacultyListVM> model = new Paginate<FacultyListVM>(optionVm, page, pageCount);
            //return View(model);
            return View();


        }
        public async Task<IActionResult> FacultyTable(int page = 1)
        {
            int count = 6;
            ViewBag.TakeCount = count;
            var Faculties = await _context.Faculties
                                               .Include(f => f.Groups)
                                                .Skip((page - 1) * count)
                                              .Take(count)
                                               .ToListAsync();


            var optionVm = GetFacultyList(Faculties); 
            int pageCount = GetPageCount(count);
            Paginate<FacultyListVM> model = new Paginate<FacultyListVM>(optionVm, page, pageCount);
            return View(model);

        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Faculties.Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<FacultyListVM> GetFacultyList(List<Faculty> options)
        {
            List<FacultyListVM> model = new List<FacultyListVM>();
            foreach (var item in options)
            {
                var option = new FacultyListVM

                {
                    Name = item.Name,
                    Id = item.Id,
                    GroupCount = item.Groups.Count()

                };
                model.Add(option);
            }
            return model;
        }

        // GET: FacultyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FacultyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacultyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FacultyCreateVM facultyCreateVM)
        {
            if (!ModelState.IsValid) return View();
            bool IsExist = _context.Faculties
                                 .Any(c => c.Name.ToLower().Trim() == facultyCreateVM.Name.ToLower().Trim());
            if (IsExist)
            {
                TempData["Warning"] = "This faculty already exist";
                ModelState.AddModelError("Name","This faculty already exist");
                return View();
            }
            Faculty faculty = new Faculty
            {

                Name = facultyCreateVM.Name
            };
            await _context.Faculties.AddAsync(faculty);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Faculty Created";
            return RedirectToAction(nameof(FacultyTable));
        }

        // GET: FacultyController/Edit/5
        public async Task<IActionResult> Update(int id)
        {
            Faculty faculty = await _context.Faculties.FindAsync(id);
            if (faculty == null) return NotFound();
            return View(faculty);
        }

        // POST: FacultyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Faculty faculty)
        {
          
            if (!ModelState.IsValid) return View();
            if (id != faculty.Id) return BadRequest();

            Faculty dbCategory = await _context.Faculties.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (faculty.Name != null)
            {
               if (dbCategory == null) return NotFound();
                if (dbCategory.Name.ToLower().Trim() == faculty.Name.ToLower().Trim())
                {
                    return RedirectToAction(nameof(FacultyTable));
                }
                bool IsExist = _context.Faculties
                                    .Any(c => c.Name.ToLower().Trim() == faculty.Name.ToLower().Trim());
                if (IsExist)
                {
                    TempData["Warning"] = "This faculty already exist";
                    ModelState.AddModelError("Name", "This faculty already exist");
                    return View(dbCategory);
                }

                dbCategory.Name = faculty.Name;
            }
            else
                dbCategory.Name = dbCategory.Name;

            await _context.SaveChangesAsync();
            TempData["Success"] = "Faculty Uptated";
            return RedirectToAction(nameof(FacultyTable));
        }
    }

    // GET: FacultyController/Delete/5
    //public async Task<IActionResult> Delete(int id)
    //{
    //  //  Faculty faculty = await _context.Faculties.Where( f=>f.Id == id).FirstOrDefaultAsync();
    //  //  var facultyGroupList = _context.Groups.Include(x => x.UserGroups).Select(x => x.UserGroups.Where(x => x.GroupId == id));
    //  ////  var classUserList = _context.Groups.Include(x => x.UserGroups).Select(x => x.UserGroups.Where(x => x.GroupId == id));
    //  //  var classSubjextList = _context.Subjects.Include(x => x.GroupSubjects).Select(x => x.GroupSubjects.Where(x => x.GroupId == id));
    //  //  if (faculty == null) return NotFound();
    //  //  foreach (var item in classUserList)
    //  //  {
    //  //      _context.UserGroups.RemoveRange(item);
    //  //  }
    //  //  foreach (var sbj in classSubjextList)
    //  //  {
    //  //      _context.GroupSubjects.RemoveRange(sbj);
    //  //  }

    //  //  _context.Groups.Remove(group);
    //  //  await _context.SaveChangesAsync();
    //    return View();
    //}

    //// POST: FacultyController/Delete/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Delete(int id, IFormCollection collection)
    //{
    //    try
    //    {
    //        return RedirectToAction(nameof(Index));
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}

   
}

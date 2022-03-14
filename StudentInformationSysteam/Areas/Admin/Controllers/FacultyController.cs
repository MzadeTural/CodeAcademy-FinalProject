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
    public class FacultyController : Controller
    {
        private readonly AppDbContext _context;

        public FacultyController(AppDbContext context)
        {
            _context = context;
        }
        // GET: FacultyController
        public async Task<IActionResult> Index( int page = 1)
        {
            int count = 2;
            ViewBag.TakeCount = count;
            var Faculties = await _context.Faculties
                                               .Include(f => f.Groups)
                                               .ToListAsync();


            var optionVm = GetProductList(Faculties);
            int pageCount = GetPageCount(count);
            Paginate<FacultyListVM> model = new Paginate<FacultyListVM>(optionVm, page, pageCount);
            return View(model);

            
        }
        public async Task<IActionResult> FacultyTable(int page)
        {
            int count = 2;
            ViewBag.TakeCount = count;
            var Faculties = await _context.Faculties
                                               .Include(f => f.Groups)
                                               .ToListAsync();


            var optionVm = GetProductList(Faculties);
            int pageCount = GetPageCount(count);
            Paginate<FacultyListVM> model = new Paginate<FacultyListVM>(optionVm, page, pageCount);
            return View(model);

        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Groups.Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<FacultyListVM> GetProductList(List<Faculty> options)
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

        // GET: FacultyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FacultyController/Edit/5
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

        // GET: FacultyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FacultyController/Delete/5
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

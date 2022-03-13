using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSysteam.Business.ViewModel.FacultyVM;
using StudnetInformationSysteam.Data.DAL;
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
        public async Task<ActionResult> Index()
        {
            FacultyListVM facultyList = new FacultyListVM 
            { 
            Faculties=await _context.Faculties
                                              .Include(f=>f.Groups)
                                              .ToListAsync()
            
            };

         
           
            return View(facultyList);
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

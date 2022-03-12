using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    public class FroupController : Controller
    {
        // GET: FroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FroupController/Create
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

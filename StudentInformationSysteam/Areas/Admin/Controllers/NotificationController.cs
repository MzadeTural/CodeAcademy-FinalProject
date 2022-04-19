using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.Notification;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NotificationController : Controller
    {
        private readonly AppDbContext _context;

        public NotificationController( AppDbContext context)
        {
            _context = context;
        }
        // GET: NotificationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotificationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotificationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateNotificationVM createNotification)
        {
            if (!ModelState.IsValid) return View();
            bool IsExist = _context.Notifications
                                 .Any(c => c.Title.ToLower().Trim() == createNotification.Title.ToLower().Trim());
            if (IsExist)
            {
                ModelState.AddModelError("Title", "This name already exist");
                return RedirectToAction(nameof(Index));
            }
            Notification notification = new Notification
            {

                Title = createNotification.Title,
                Message=createNotification.Description
                
            };
            await _context.Notifications.AddAsync(notification);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Notification sent";
            return RedirectToAction(nameof(Create));
        }

        // GET: NotificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotificationController/Edit/5
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

        // GET: NotificationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotificationController/Delete/5
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

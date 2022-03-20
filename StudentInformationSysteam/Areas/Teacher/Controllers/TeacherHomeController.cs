using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{ [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class TeacherHomeController : Controller
    {
        private readonly object _context;

        public TeacherHomeController(object context)
        {
            _context = context;
        }

        public TeacherHomeController()
        {

        }
        public IActionResult Index()
        {
            ViewBag.Notifications = _context.Notifications.OrderByDescending(n => n.Id).Take(5).ToList();
            return View();
        }
    }
}

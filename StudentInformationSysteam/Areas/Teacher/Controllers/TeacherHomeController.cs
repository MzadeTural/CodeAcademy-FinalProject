using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{ [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class TeacherHomeController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherHomeController(AppDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            ViewBag.Notifications = _context.Notifications.OrderByDescending(n => n.Id).Take(5).ToList();
            return View();
        }
    }
}

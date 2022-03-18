using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{ [Area("Teacher")]
    public class TeacherHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{ [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class TeacherHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

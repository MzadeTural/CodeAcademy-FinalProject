using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

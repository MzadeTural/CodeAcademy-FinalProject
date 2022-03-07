using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

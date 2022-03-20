using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Controllers
{
    public class NorFoundError : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

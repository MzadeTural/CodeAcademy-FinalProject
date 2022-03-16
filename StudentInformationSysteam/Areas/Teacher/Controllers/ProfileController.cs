using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

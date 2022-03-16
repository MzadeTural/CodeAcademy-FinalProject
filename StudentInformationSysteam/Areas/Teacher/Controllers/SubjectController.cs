using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

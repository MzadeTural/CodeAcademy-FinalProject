using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Controllers
{
    public class TranscriptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

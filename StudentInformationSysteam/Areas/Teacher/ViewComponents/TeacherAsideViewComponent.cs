using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSysteam.Areas.Teacher.ViewComponents
{
    public class TeacherAsideViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

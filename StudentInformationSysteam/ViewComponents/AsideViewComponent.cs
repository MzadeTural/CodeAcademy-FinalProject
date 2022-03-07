using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace StudentInformationSysteam.ViewComponents
{
    public class AsideViewComponent:ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return  View();
        }
    }
}

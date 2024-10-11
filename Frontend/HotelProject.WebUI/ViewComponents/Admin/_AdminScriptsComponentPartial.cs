using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Admin
{
    public class _AdminScriptsComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

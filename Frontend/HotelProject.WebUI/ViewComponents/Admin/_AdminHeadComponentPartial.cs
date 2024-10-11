using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Admin
{
    public class _AdminHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

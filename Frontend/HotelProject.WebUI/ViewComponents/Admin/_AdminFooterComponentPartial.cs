using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Admin
{
    public class _AdminFooterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

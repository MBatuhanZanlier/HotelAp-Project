using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _DefaultAboutComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

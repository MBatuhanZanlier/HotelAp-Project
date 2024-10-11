using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _DefaultServiceComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}

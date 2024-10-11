using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _DefaultTeamComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}

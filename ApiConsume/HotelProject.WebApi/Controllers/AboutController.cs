using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult GetListAbout()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok("Başarıyla Eklendi");

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetbyId(id);
            _aboutService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(About updateAbout)
        {
            _aboutService.TUpdate(updateAbout);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("{id}")] 
        public ActionResult GetAbout(int id)  
        {  
         var values=_aboutService.TGetbyId(id); 
            return Ok(values);  
        
        }
    }
    
}

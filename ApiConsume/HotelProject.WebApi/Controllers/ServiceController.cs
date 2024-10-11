using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    { 
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }
       [HttpGet]
        public IActionResult ServiceList()
        { 
            var values=_servicesService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        { 
            var values=_servicesService.TGetbyId(id); 
            _servicesService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        { 
            _servicesService.TInsert(service);
            return Ok("Başarıyla Eklendi");
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        { 
            _servicesService.TUpdate(service);  
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        { 
            var values= _servicesService.TGetbyId(id);
            return Ok(values);
        }
    }
}

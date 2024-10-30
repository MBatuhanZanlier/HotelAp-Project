using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _worklocationservice;

        public WorkLocationController(IWorkLocationService worklocationservice)
        {
            _worklocationservice = worklocationservice;
        }

        [HttpGet]
        public IActionResult GetWorkLocation()
        {

            var values=_worklocationservice.TGetList(); 
            return Ok(values);
        }

        [HttpPost] 
        public IActionResult AddWroklocation(WorkLocation workLocation)
        {
            _worklocationservice.TInsert(workLocation);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete("{id}")] 
        public IActionResult DeleteWorklocation(int id)  
        {  
             
            var values=_worklocationservice.TGetbyId(id); 
            _worklocationservice.TDelete(values);
            return Ok("Başarıyla Silindi"); 
        
        }

        [HttpPut] 
        public IActionResult UpdateWorklocation(WorkLocation workLocation)
        {
            _worklocationservice.TUpdate(workLocation);
            return Ok("Başarıyla Eklendi");
        }
        [HttpGet("{id}")] 
        public IActionResult GetIdWorkLocation(int id)
        {
            var values = _worklocationservice.TGetbyId(id); 
            return Ok(values);
        }
     }
}

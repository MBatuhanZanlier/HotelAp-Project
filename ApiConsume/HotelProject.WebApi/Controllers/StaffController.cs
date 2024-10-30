using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        { 
            var values=_staffService.TGetbyId(id);
            _staffService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        { 
            _staffService.TInsert(staff);
            return Ok("Başarıyla Eklendi");
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        { 
            _staffService.TUpdate(staff);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values= _staffService.TGetbyId(id);
            return Ok(values);
        }
        [HttpGet("Last4Staff")] 
        public IActionResult Last4Staff()
        {
            var values=_staffService.TLast4Staff(); 
            return Ok(values);
        }
    }
}

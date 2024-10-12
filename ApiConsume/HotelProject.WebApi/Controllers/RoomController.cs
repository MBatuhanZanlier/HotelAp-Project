using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    { 
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        { 
            var values=_roomService.TGetList();
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok();
        }
    }
}

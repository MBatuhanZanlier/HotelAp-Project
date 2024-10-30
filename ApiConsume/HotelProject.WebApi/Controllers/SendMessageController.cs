using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendService;

        public SendMessageController(ISendMessageService sendService)
        {
            _sendService = sendService;
        }


        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {

            _sendService.TInsert(sendMessage);
            return Ok("Başarıyla Eklendi");

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendService.TGetbyId(id);
            _sendService.TDelete(values);
            return Ok("Başarıyla Eklendi");

        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendService.TUpdate(sendMessage);
            return Ok("Başarıyla Güncellendi");

        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _sendService.TGetbyId(id);
        return Ok(values);
        }
        [HttpGet("GetSendMessageCount")] 
        public IActionResult GetSendMessageCount()
        {
            return Ok(_sendService.TGetSendMessageCount());
        }
    }
}

using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messagecategory;

        public MessageCategoryController(IMessageCategoryService messagecategory)
        {
            _messagecategory = messagecategory;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _messagecategory.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messagecategory.TInsert(messageCategory);
            return Ok("Başarıyla Eklendi");

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _messagecategory.TGetbyId(id);
            _messagecategory.TDelete(values);
            return Ok("Başarıyla Silindi");


        }
        [HttpPut] 
        public IActionResult UpdateMessageCategory(MessageCategory messageCategory)
        {
            _messagecategory.TUpdate(messageCategory);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]    
        public IActionResult GetbyId(int id)  
        {  
           var values= _messagecategory.TGetbyId(id);
            return Ok(values);
        
        }
    }
}

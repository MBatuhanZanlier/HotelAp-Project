using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult ListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        { 
            contact.Date=Convert.ToDateTime(DateTime.Now.ToString());   
            _contactService.TInsert(contact);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetbyId(id);
            _contactService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.TUpdate(contact);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)  
        {
            var values = _contactService.TGetbyId(id); 
            return Ok(values);
        
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
           return Ok(_contactService.TGetContactCount()); 
        }
    }
}

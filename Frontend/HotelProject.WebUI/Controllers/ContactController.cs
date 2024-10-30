using HotelProject.WebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendMessagee(CreateContactDto contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client =_httpClientFactory.CreateClient(); 
            var jsonData=JsonConvert.SerializeObject(contact); 
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            await client.PostAsync("http://localhost:55844/api/Contact", content); 
            return RedirectToAction("Index","Default");
        }
   
    }
}

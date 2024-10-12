using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    { 
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> CreateSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient(); 
            var jsonData=JsonConvert.SerializeObject(createSubscribeDto); 
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:55844/api/Subscribe", stringContent); 
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            } 
            return View();
          
        }
    }
}

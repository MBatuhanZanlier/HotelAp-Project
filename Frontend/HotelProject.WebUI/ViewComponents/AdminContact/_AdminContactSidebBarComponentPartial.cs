
using HotelProject.DataAccessEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.AdminContact
{
    public class _AdminContactSidebBarComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminContactSidebBarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55844/api/Contact/GetContactCount");


            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("http://localhost:55844/api/SendMessage/GetSendMessageCount");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.sendmessage= jsonData2;
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.ınbox = jsonData;



            }

            return View();
        }
    }
}

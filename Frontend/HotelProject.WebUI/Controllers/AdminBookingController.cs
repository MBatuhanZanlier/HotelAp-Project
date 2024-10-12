using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        { 
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55844/api/Booking"); 
            if(responseMessage.IsSuccessStatusCode)  
            {  
                var jsonData=await responseMessage.Content.ReadAsStringAsync();  
                var values=JsonConvert.DeserializeObject<List<ResultBookinDto>>(jsonData); 
                return View(values);
            }
            return View();
        }
      
        public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto reservationDto)
        {
            reservationDto.Status = "Onaylandı";
            var client = _httpClientFactory.CreateClient(); 
            var jsonData=JsonConvert.SerializeObject(reservationDto); 
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("", stringContent); 
            if(responseMessage.IsSuccessStatusCode)  
            {
                return RedirectToAction("Index");
            
            }
            return View();        }
    }
}

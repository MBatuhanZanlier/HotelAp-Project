using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BookingRapidApiConsume.Models;
using Newtonsoft.Json;
using System.Linq;

namespace BookingRapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityname)
        {  
            if(!string.IsNullOrEmpty(cityname))
            {
                List<BookinApiLocationSearchViewModel> model = new List<BookinApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name=Berlin"),
                    Headers =
    {
        { "x-rapidapi-key", "72cbb4ac4emsh3afb8a14be06363p13e816jsn74e082590fd8" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<BookinApiLocationSearchViewModel>>(body);
                    return View(model.Take(1).ToList());

                }
               
            }
            return View();
        }
    }
}


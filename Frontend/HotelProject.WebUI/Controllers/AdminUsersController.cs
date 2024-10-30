using HotelProject.WebUI.Dtos.AppuserDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUsersController : Controller
    { 
        private readonly IHttpClientFactory _httpclientFactory;

        public AdminUsersController(IHttpClientFactory httpclientFactory)
        {
            _httpclientFactory = httpclientFactory;
        } 

        public async Task<IActionResult> Index()
        {
            var client=_httpclientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55844/api/AppUser"); 
            if(responseMessage.IsSuccessStatusCode)  
            {  
            
               var jsonData=await responseMessage.Content.ReadAsStringAsync(); 
                var values=JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsonData); 
                return View(values);    
            
            } 
            return View();
        }
    }
}

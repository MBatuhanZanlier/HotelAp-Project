using HotelProject.WebUI.Dtos.WorkLocationDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminWorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpclientfactory;

        public AdminWorkLocationController(IHttpClientFactory httpclientfactory)
        {
            _httpclientfactory = httpclientfactory;
        }

        public async Task<IActionResult> Index()
        { 
            var client =_httpclientfactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55844/api/WorkLocation"); 
            if(responseMessage.IsSuccessStatusCode)  
            {  
               var jsonData=await responseMessage.Content.ReadAsStringAsync(); 
                var values=JsonConvert.DeserializeObject<List<ResultWorkLocationDto>>(jsonData); 
                return View(values);
            
            }
            return View();
        }
        [HttpGet] 
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> AddRoom(CreateWorkLocationDto createWorkLocationDto)
        {
            var client=_httpclientfactory.CreateClient(); 
            var jsonData=JsonConvert.SerializeObject(createWorkLocationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:55844/api/WorkLocation/", stringContent); 
            if(responseMessage.IsSuccessStatusCode)  
            {  
               return RedirectToAction("Index");
            
            } 
            return View();  
        }

        [HttpDelete] 
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var client = _httpclientfactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:55844/api/WorkLocation/{id}"); 
            if(responseMessage.IsSuccessStatusCode)  
            {

                return RedirectToAction("Index"); 
            }
            return View();
        }
        [HttpGet]   
        public async Task<IActionResult> UpdateLocation(int id)
        {
            var client = _httpclientfactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:55844/api/WorkLocation/{id}"); 
            if(responseMessage.IsSuccessStatusCode)  
            {

                return RedirectToAction("Index");
            
            
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateLocation(UpdateWorkLocationDto updateWorkLocationDto)
        {
            var client= _httpclientfactory.CreateClient(); 
            var jsondata=JsonConvert.SerializeObject(updateWorkLocationDto); 
            StringContent stringContent=new StringContent(jsondata,Encoding.UTF8,"application/json"); 
            var responseMessage=await client.PutAsync("http://localhost:55844/api/WorkLocation", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

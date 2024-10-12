using HotelProject.WebUI.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async  Task<IViewComponentResult> InvokeAsync()
        {  
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:55844/api/Testimonial"); 
            if(responseMessage.IsSuccessStatusCode)  
            {  
                 var jsonData= await responseMessage.Content.ReadAsStringAsync(); 
                var values=JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData); 
                return View(values);
            
            }
            return View();  
        
        }
    }
}

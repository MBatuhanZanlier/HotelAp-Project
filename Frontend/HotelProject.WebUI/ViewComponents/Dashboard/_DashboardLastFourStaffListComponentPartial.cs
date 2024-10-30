using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLastFourStaffListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpclient;

        public _DashboardLastFourStaffListComponentPartial(IHttpClientFactory httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<IViewComponentResult> InvokeAsync()  
        {   var client=_httpclient.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:55844/api/Staff/Last4Staff"); 
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata= await responsemessage.Content.ReadAsStringAsync();     
                var values=JsonConvert.DeserializeObject<List<ResultStaffLastFourDto>>(jsondata); 
                return View(values);
            }
            return View();  
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWigetComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWigetComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:55844/api/Dashboard/StaffCount");

            var jsonData = await responsemessage.Content.ReadAsStringAsync();
            ViewBag.v = jsonData;


            var client2 = _httpClientFactory.CreateClient();
            var responsemessage2 = await client.GetAsync("http://localhost:55844/api/Dashboard/StaffCount");
            var jsonData2 = await responsemessage.Content.ReadAsStringAsync();
            ViewBag.bookingcount = jsonData2;

            var client3 = _httpClientFactory.CreateClient();
            var responsemessage3 = await client.GetAsync("http://localhost:55844/api/Dashboard/AppUserCount");
            var jsonData3 = await responsemessage.Content.ReadAsStringAsync();
            ViewBag.userscount = jsonData3;

            var client4 = _httpClientFactory.CreateClient();
            var responsemessage4 = await client.GetAsync("http://localhost:55844/api/Dashboard/AppUserCount");
            var jsonData4 = await responsemessage.Content.ReadAsStringAsync();
            ViewBag.roomcount = jsonData4;
            return View();
        }
    }
}

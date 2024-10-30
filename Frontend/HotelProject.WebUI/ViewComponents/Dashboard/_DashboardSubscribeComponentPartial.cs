using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FlowersDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeComponentPartial : ViewComponent
    { 

        public async Task<IViewComponentResult> InvokeAsync()
        {
          
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/murattycedag"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "72cbb4ac4emsh3afb8a14be06363p13e816jsn74e082590fd8" },
    //    { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //           ResultInstagramFlowersDto ınstagramFlowersDto=JsonConvert.DeserializeObject<ResultInstagramFlowersDto>(body);
    //            ViewBag.instagramfollowers = ınstagramFlowersDto.followers;
    //            ViewBag.instagramfollowing = ınstagramFlowersDto.following;
    //        }

        
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fm%25C3%25BCcahit-batuhan-zanl%25C4%25B1er-045bb92a3%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "72cbb4ac4emsh3afb8a14be06363p13e816jsn74e082590fd8" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response = await client2.SendAsync(request2))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               ResultLinkedlnDto resultLinkedlnDto=JsonConvert.DeserializeObject< ResultLinkedlnDto>(body); 
                ViewBag.linkdln=resultLinkedlnDto.data.follower_count;
            }

            return View();
        }
    }
}

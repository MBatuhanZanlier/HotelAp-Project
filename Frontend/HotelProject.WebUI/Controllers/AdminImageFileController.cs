using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        { 
            var stream=new MemoryStream(); 
            await file.CopyToAsync(stream); 
            var bytes=stream.ToArray(); 

            ByteArrayContent content = new ByteArrayContent(bytes); 
            content.Headers.ContentType=new MediaTypeHeaderValue(file.ContentType); 
            MultipartFormDataContent contentContent = new MultipartFormDataContent();
            contentContent.Add(content, "file", file.FileName);
            var httpclilent = new HttpClient();
            var responseMessage = await httpclilent.PostAsync("http://localhost:55844/api/FileImage", contentContent); 
   
            return View();
        }
    }
}

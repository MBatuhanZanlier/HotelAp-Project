using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")] 
        public IActionResult TokenOluştur()
        {
            return Ok(new CreateToken().TokenCreate());
        }
     
        [HttpGet("[action]")]
        public  IActionResult AdminTokenOluştur()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }

        [Authorize(Roles ="Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Giriş Başarılı");
        }
    }
}

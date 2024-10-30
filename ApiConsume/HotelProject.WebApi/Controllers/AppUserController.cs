using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessEntityLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet]
        public IActionResult AppUserWithWorkLocation()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorklocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl,
                Country = y.Country

            }); 
            return Ok(values);
        }
        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
    }
}

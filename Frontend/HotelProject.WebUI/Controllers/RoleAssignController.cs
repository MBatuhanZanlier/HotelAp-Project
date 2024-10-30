using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        public async Task<IActionResult> AssingRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRole = await _userManager.GetRolesAsync(user);
            List<RoleAssingViewModel> roleAssingViewModels = new List<RoleAssingViewModel>();
            foreach (var item in roles)
            {
                RoleAssingViewModel roleAssingViewModel = new RoleAssingViewModel();
                roleAssingViewModel.RoleId = item.Id;
                roleAssingViewModel.RoleName = item.Name;
                roleAssingViewModel.RoleExist = userRole.Contains(item.Name);
            }
            return View(roleAssingViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AssingRole(List<RoleAssingViewModel> roleAssingViewModels)
        {
            var userıd = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userıd);
            foreach (var item in roleAssingViewModels)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName); 
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
                
            } 
            return RedirectToAction("Index");
        }
    }
}

using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = user.Name;
            userEditViewModel.Surname = user.Surname;
            userEditViewModel.Username = user.UserName;
            userEditViewModel.Email = user.Email;
            return View(userEditViewModel);

        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditView)
        {
            if (userEditView.Password == userEditView.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = userEditView.Name;
                user.Surname = user.Surname;
                user.Email = userEditView.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditView.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");
            }

            return View();
        }
    }
}

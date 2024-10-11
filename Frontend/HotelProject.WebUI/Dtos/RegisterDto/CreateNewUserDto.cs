using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname{ get; set; }
        [Required(ErrorMessage = "Kullanıcı adı Gereklidir")]
        public string Usurname { get; set; }     
        [Required(ErrorMessage ="Mail Alanı Gereklidir")]
        public string Mail {  get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı Gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı Gereklidir")]
        [Compare("Password",ErrorMessage ="Şifre uyuşmuyor")]
        public string   ConfirmPassword { get; set; }
    }
}

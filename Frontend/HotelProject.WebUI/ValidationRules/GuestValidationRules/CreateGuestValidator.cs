using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Alanı Boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim 3 karekterden az olamaz");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Soyisim 3 karekterden az olamaz");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir 3 karekterden az olamaz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("İsim 20 karekterden fazla olamaz");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Soyisim 20 karekterden fazla olamaz");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Şehir 20 karekterden fazla olamaz");

        }
    }
}

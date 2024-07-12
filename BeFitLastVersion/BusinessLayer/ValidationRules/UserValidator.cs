using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez")
                .MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız")
                .MaximumLength(50).WithMessage("Lütfen 50 Karakterden Az Veri Girişi Yapınız");

            RuleFor(x => x.UserPassword)
                .NotEmpty().WithMessage("Şifre Boş Geçilemez")
                .MinimumLength(8).WithMessage("Şifre 8 Karakterden Uzun Olmalıdır");

            RuleFor(x => x.UserEmail)
                .NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");

        }
    }
}

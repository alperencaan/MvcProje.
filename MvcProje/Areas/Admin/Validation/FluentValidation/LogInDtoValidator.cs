using FluentValidation;
using ModelLayer.DTO;

namespace MvcProje.Areas.Admin.Validation.FluentValidation
{
    public class LogInDtoValidator : AbstractValidator<LogInDTO>
    {
        public LogInDtoValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .WithMessage("Kullanıcı Adı Boş Geçişlemez.");
            RuleFor(x => x.Username)
                .MinimumLength(5)
                .WithMessage("Kullanıcı Adı Enaz 5 Karakterden Oluşmalıdır.");
            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("Şifre Bilgisi Boş Geçilemez.");
            RuleFor(x => x.Password)
                .MaximumLength(15)
                .WithMessage("Şifre Bilgisi 15 Karakterden Fazla olamaz.");
        }
    }
}

using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez !");
            RuleFor(x => x.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harfden ibaret olmalıdır.");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en azı bir küçük harfden ibaret olmalıdır.");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");
            RuleFor(x => x.WriterName).MinimumLength(8).WithMessage("Ad Soyad En az 8 Karakter olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(60).WithMessage("Ad Soyad En fazka 60 Karakter olabilir.");
        }
    }
}

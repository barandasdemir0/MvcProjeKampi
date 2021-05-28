using EntityLayer.Concrete;//contact için
using FluentValidation;//abstract validator için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //rule for kural için demek ne için kural category validation validation ne demek doğrulama altta Linq sorgusu yazdık x öyleki x büyüktür category name boş olamaz notempty ardından withmessage ile mesaj yazdırdık burada rahatça türkçe kelime yazdık
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçimezsiniz ");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En az 3 Karakter Girişi yapın");//minumum length ile uzunluğu en az 3 olan kelimeleri girmesini istedik
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden fazla değer girişi yapmayın");//maximum length ile maximum uzunluğu girmesini istedik
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 Karakterden fazla değer girişi yapmayın");//maximum length ile maximum uzunluğu girmesini istedik
        }
    }
}

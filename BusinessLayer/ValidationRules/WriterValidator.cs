using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //rule for kural için demek ne için kural writer validation validation ne demek doğrulama altta Linq sorgusu yazdık x öyleki x büyüktür writer name boş olamaz notempty ardından withmessage ile mesaj yazdırdık burada rahatça türkçe kelime yazdık
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını Boş geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En az 3 Karakter Girişi yapın");//minumum length ile uzunluğu en az 3 olan kelimeleri girmesini istedik
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 20 Karakterden fazla değer girişi yapmayın");//maximum length ile maximum uzunluğu girmesini istedik
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("Ünvan Kısmını Boş Geçemezsiniz");//ünvana veri girmesini istedik
            


        }
    }
}

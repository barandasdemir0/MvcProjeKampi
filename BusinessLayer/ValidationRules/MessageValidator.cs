using EntityLayer.Concrete;//messsage için
using FluentValidation;//abstrackvalidator için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            //rule for kural için demek ne için kural Message validation validation ne demek doğrulama altta Linq sorgusu yazdık x öyleki x büyüktür Message name boş olamaz notempty ardından withmessage ile mesaj yazdırdık burada rahatça türkçe kelime yazdık
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş geçemezsiniz");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Açıklaması Boş Geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı  Boş Geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En az 3 Karakter Girişi yapın");//minumum length ile uzunluğu en az 3 olan kelimeleri girmesini istedik
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 Karakterden fazla değer girişi yapmayın");//maximum length ile maximum uzunluğu girmesini istedik
        }
    }
}

using EntityLayer.Concrete;//category üzerine eklenen kütüphane
using FluentValidation;//abstrackvalidatör hatası sonrası eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //burada kategori için gerekli kuralları yazacağız
    public class CategoryValidator : AbstractValidator<Category> //üzerinde çalıştığımız için category yazdık   
    {
        public CategoryValidator()
        {
            //rule for kural için demek ne için kural category validation validation ne demek doğrulama altta Linq sorgusu yazdık x öyleki x büyüktür category name boş olamaz notempty ardından withmessage ile mesaj yazdırdık burada rahatça türkçe kelime yazdık
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş geçemezsiniz");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Boş Geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En az 3 Karakter Girişi yapın");//minumum length ile uzunluğu en az 3 olan kelimeleri girmesini istedik
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden fazla değer girişi yapmayın");//maximum length ile maximum uzunluğu girmesini istedik

            // ÖRNEK OLARAK AŞŞAĞIDA Kİ AÇIKLAMA SATIRI OLMADA

            //RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!");
            //RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı 3 Karaketerden Küçük Olamaz!");
            //RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Kategori Adı 25 Karakterden Büyük Olamaz!");
            //RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Lütfen Açıklama Giriniz!");
        }
    }
}

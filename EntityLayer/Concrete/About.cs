using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
             //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int AboutID { get; set; }
        [StringLength(500)]//senin maksimum uzunluğun 500 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string AboutDetails1 { get; set; }//tema da 2 nokta var o yüzden
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }//tema da 2 nokta var o yüzden
        [StringLength(100)]
        public string AboutImage1 { get; set; }//tema da 2 nokta var o yüzden ve dosyaya kaydediyoruz dosya yolu ile almak daha sağlıklı
        [StringLength(100)]
        public string AboutImage2 { get; set; }//tema da 2 nokta var o yüzden ve dosyaya kaydediyoruz dosya yolu ile almak daha sağlıklı
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
        //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int WriterID { get; set; }//yazar ıd
        [StringLength(50)]//senin maksimum uzunluğun 50 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string WriterName { get; set; }//yazar ad
        [StringLength(50)]
        public string WriterSurName { get; set; }//yazar soyad
        [StringLength(100)]
        public string WriterImage { get; set; } //yazar resim

        [StringLength(100)]
        public string WriterAbout { get; set; }//yazar hakkında

        //şifrelemek için burayı 200 yaptık
        [StringLength(200)]
        public string WriterMail { get; set; }//yazar mail
        [StringLength(200)]
        public string WriterPassword { get; set; }//yazar şifre
        [StringLength(50)]
        public string WriterTitle { get; set; }//yazar başlık


        //birden fazla yazar için yorum yapacakarından bu alttaki 2 kodu yazdık
        public ICollection<Heading>  Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}

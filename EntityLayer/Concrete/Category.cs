using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
             //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int CategoryID { get; set; }//kategori id
        [StringLength(50)]//senin maksimum uzunluğun 50 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string CategoryName { get; set; } //kategori adı
        [StringLength(200)]
        public string CategoryDescription { get; set; } //kategori açıklaması decsription açıklama demek
        public bool CategoryStatus { get; set; } //kategoriyi aktif ve pasif etmek için
        public ICollection<Heading> headings { get; set; } 
        // --> category sınıfında ı collection türünde property oluşturduk(prop yazıp get set yani) sen dedim heading ile ilişkili olacaksın
    }
}

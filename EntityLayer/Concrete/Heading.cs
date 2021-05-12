using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading //heryerden erişim sağlamak adına public yazdık başına
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
             //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int HeadingID { get; set; }//veritabanında tanımlayacağımız yer Headingin ıdsi integer veri tipinde
        [StringLength(50)]//senin maksimum uzunluğun 50 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string HeadingName { get; set; } //veritabanında tanımlayacağımız yer Headingin adı string veri tipinde
        public DateTime HeadingDate { get; set; } //veritabanında tanımlayacağımız yer Headingin tarih bilgisi tarih veri tipinde



        //ketogori ile başlığı etkileşimli haletirdik aşşağıdaki 2 kod ile
        public int CategoryID { get; set; }// -->sen benim ilişkili tablomda ıdli değerim olacaksın
        public virtual Category Category { get; set; }
        // sen kategori sınıfından kategori adında değer oluştur anahtar olsun buda


        //-->> bu alttaki kod ile başlığın kimin açtığını bulabileceğiz
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; }// sen benim koleksiyonumu oluştur neyle content sınıfıyla contents adıyla

    }
}

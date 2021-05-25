using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
             //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int ContentID { get; set; }
        [StringLength(1000)]//senin maksimum uzunluğun 1000 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string ContentValue { get; set; } //içeriğin değeri content içerik demek value değer demek
        public DateTime ContentDate { get; set; }

        //başlıkla içeriği etkileşimli haletirdik aşşağıdaki 2 kod ile
        public int HeadingID { get; set; }// -->sen benim ilişkili tablomda ıdli değerim olacaksın
        public virtual Heading Heading{ get; set; } // sen headind sınıfından heading adında değer oluştur anahtar olsun buda
        public bool ContentStatus { get; set; }//true ve false yapmak için yani aktif pasif işlemi

        //yorum yapan yazarların  ıdsını aldık
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}

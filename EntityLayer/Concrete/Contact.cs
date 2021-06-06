using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//bunu ekliyoruz ama bunu eklemeden önce nuget bölümünden entity framework 6 yı indiriyoruz
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]//bunu yazınca hata verecek  nuget bölümünden entity framework 6 yı indiriyoruz ardından olası düzeltmelere basıp yukarıdaki kütüphaneyi ekliyoruz
             //key sayesinde kısıtlayıcı getirdik verdiğimiz değer kadar gidicek daha fazla deer alamayacak
        public int ContactID { get; set; }
        [StringLength(50)]//senin maksimum uzunluğun 50 olsun hangi propertynin üzerinde tanımlarsak onun kini etkileyecek
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; } //konu subject
        public DateTime ContactDate { get; set; }

        public string Message { get; set; }
    }
}

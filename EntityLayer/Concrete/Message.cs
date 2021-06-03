using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//key sonucu oluşan kütüphane
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }//mesajın IDsi
        [StringLength(50)]
        public string SenderMail { get; set; }//gönderen
        [StringLength(50)]
        public string ReceiverMail { get; set; }//alıcı
        [StringLength(100)]
        public string Subject { get; set; }//konusu
        public string MessageContent { get; set; }//mesajın içeriği
        public DateTime MessageDate { get; set; }//mesajın tarihi

    }
}

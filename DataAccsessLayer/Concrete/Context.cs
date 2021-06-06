using EntityLayer.Concrete;//başvurulardan projelerden bunu ekleyecez ardından abputta hata verince hatayı düzelt deyince bu kütüphanenin seçeneğini ekleyeceğiz yani kendi ekleyecek
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccsessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }//başvurulardan projelerden bunu ekleyecez ardından aboutta hata verince hatayı düzelt deyince bu kütüphanenin seçeneğini ekleyeceğiz
        //about bizdeki karşılığı abouts ise veritbanımızdaki karşılığı alttakilerde aynı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }//eğer bunu eklemeden migrations işlemi yaparsak boş döndürür ve böylelikle veritabanınıa yansımaz
        public DbSet<ImageFile> ımageFiles { get; set; }
    }
}

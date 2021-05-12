using DataAccsessLayer.Abstract;//hata çıkarınca bu kütüphane tanımlandı
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;//bunu ekleyine düzeltti dbset hatasını
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/*
 * BAZI ÖRNEK METOTLAR VE ANLAMLARI
 ToList = listelemek için
 Add = eklemek için
 Remove = silmek için
 Find = bulmak
 */

namespace DataAccsessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal //hata çıkaracak ve en baştaki kütüphane tanımlanacak ardından bir sonraki hatada ise tıklayıp methodları oluşturacak aşşağıdaki metodlar yani alfabetik sırayla oluştu
    {
        Context c = new Context();
        DbSet<Category> _object; //dbset hatası çıkacak bunu yukarıdaki kütüphaneyi ekleyince düzelir hatadan kütüphane çıkacak
        public void Delete(Category p)
        {
            _object.Remove(p);//parametreden gelen değeri benim _object değerime sil
            c.SaveChanges();//contextdeki değişiklikleri kaydet 
        }
        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public void Insert(Category p)
        {
            _object.Add(p);//parametreden gelen değeri benim _object değerime ekle
            c.SaveChanges();//contextdeki değişiklikleri kaydet 
        }
        public List<Category> List()
        {
            return _object.ToList();//contextdeki değişiklikleri göster 
        }
        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public void Update(Category p)
        {
            c.SaveChanges();//contextdeki değişiklikleri kaydet 
        }
    }
}
using DataAccsessLayer.Abstract;//bu eklenmeseydi hata verirdi
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();
        DbSet<T> _object;

        //ctor yazarak bu yapıyı oluştururuz
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);//silinecek entity değeri buna atama yapacaz contextten c entry entry demek giriş metot içine eklenecek parametre yani p den gelen değerimiz
            deletedEntity.State = EntityState.Deleted;//state  = durum demek deleted urum durumu şu olacak entity durumları entitiystate nokta koy sonra durumlar çıakcak deleted deyince silme metodu gelecek 
          //  _object.Remove(p); --> böylelikle yukarısı ile burası yok 
            c.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> filter)//ırepository altında hata çıkacak birinciye basınca bunu verecek bu nedir ırepositoryde bir şey tanımladın ama burada tanımlamadın diyor
        {
            return _object.SingleOrDefault(filter);//bir dizide ve ya bir listede bir değer döndürmek için kullanılan metot single for default aşşağıda ki listte tümlisteyi döndürecek ama burada tek değer
        }
        public void Insert(T p)
        {
            var addedEntity = c.Entry(p); //eklenecek entity değeri buna atama yapacaz contextten c entry entry demek giriş metot içine eklenecek parametre yani p den gelen değerimiz
            addedEntity.State = EntityState.Added;//state  = durum demek addeddurum durumu şu olacak entity durumları entitiystate nokta koy sonra durumlar çıakcak added deyince ekleme metodu gelecek 
          //  _object.Add(p); --> böylelikle yukarısı ile burası yok oldu
            c.SaveChanges();
        }
        public List<T> List()
        {
            return _object.ToList();
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();//şartlı listeleme
        }
        public void Update(T p)
        {
            var updateEntity = c.Entry(p);//güncellenecek entity değeri buna atama yapacaz contextten c entry entry demek giriş metot içine eklenecek parametre yani p den gelen değerimiz
            updateEntity.State = EntityState.Modified;// state = durum demek güncellemedurum durumu şu olacak entity durumları entitiystate nokta koy sonra durumlar çıakcak modified deyince güncelleme metodu gelecek
            c.SaveChanges();
        }
    }
}

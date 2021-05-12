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
            _object.Remove(p);
            c.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> filter)//ırepository altında hata çıkacak birinciye basınca bunu verecek bu nedir ırepositoryde bir şey tanımladın ama burada tanımlamadın diyor
        {
            return _object.SingleOrDefault(filter);//bir dizide ve ya bir listede bir değer döndürmek için kullanılan metot single for default aşşağıda ki listte tümlisteyi döndürecek ama burada tek değer
        }
        public void Insert(T p)
        {
            _object.Add(p);
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
            c.SaveChanges();
        }
    }
}

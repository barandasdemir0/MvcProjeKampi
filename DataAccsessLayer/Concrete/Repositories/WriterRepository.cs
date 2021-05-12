using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Repositories
{
    //buda örnektir 
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Category> _object; //dbset hatası çıkacak bunu yukarıdaki kütüphaneyi ekleyince düzelir hatadan kütüphane çıkacak
        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }
        void IRepository<Writer>.Delete(Writer p)
        {
            throw new NotImplementedException();
        }
        void IRepository<Writer>.Insert(Writer p)
        {
            throw new NotImplementedException();
        }
        List<Writer> IRepository<Writer>.List()
        {
            throw new NotImplementedException();
        }
        List<Writer> IRepository<Writer>.List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }
        void IRepository<Writer>.Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}

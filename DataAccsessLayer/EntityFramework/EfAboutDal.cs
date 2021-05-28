using DataAccsessLayer.Abstract;//ıaboutdal yerine oluşan kütüphane
using DataAccsessLayer.Concrete.Repositories;//generic repositoru sonucu oluşan kütüphane
using EntityLayer.Concrete;//about sonucu oluşan kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}

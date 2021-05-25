using DataAccsessLayer.Abstract;//ıcontentdal sonucu oluşan kütüphane
using DataAccsessLayer.Concrete.Repositories;//generic repository sonucu oluşan kütüphane
using EntityLayer.Concrete;//content sonucu oluşan kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
    }
}

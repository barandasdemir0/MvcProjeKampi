using DataAccsessLayer.Abstract;//writerdal için
using DataAccsessLayer.Concrete.Repositories;//generic için
using EntityLayer.Concrete;//heading için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
}

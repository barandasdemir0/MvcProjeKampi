using DataAccsessLayer.Abstract;//ıcontact için
using DataAccsessLayer.Concrete.Repositories;//generic için
using EntityLayer.Concrete;//contact için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}

using EntityLayer.Concrete;//bunu tanımlamamız sayesinde kullanmamıza izin verdi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IAboutDal:IRepository<About>
    {
    }
}

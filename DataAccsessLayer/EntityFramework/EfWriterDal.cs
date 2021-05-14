using DataAccsessLayer.Abstract;//ıwriterdal sonucu eklenen kütüphane
using DataAccsessLayer.Concrete.Repositories;//genericrepositery sonucu eklenen kütüphane
using EntityLayer.Concrete;//writer sonucu eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
    }
}

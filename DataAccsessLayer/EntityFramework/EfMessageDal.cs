using DataAccsessLayer.Abstract;//IMessageDal sonucu oluşan kütüphane
using DataAccsessLayer.Concrete.Repositories;//genericsonucu oluşan kütüphane
using EntityLayer.Concrete;//message için oluşan kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfMessageDal :  GenericRepository<Message>,IMessageDal
    {
    }
}

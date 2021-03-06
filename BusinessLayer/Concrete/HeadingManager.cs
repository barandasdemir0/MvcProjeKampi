using BusinessLayer.Abstract;//headindservicede gelen kütüphane
using DataAccsessLayer.Abstract;//headingdaldan ürettik
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;//sen ıheading daldan _headingdal adında nesne türet

        public HeadingManager(IHeadingDal headingDal)//HeadingManager üzerine gelip ctrl noktaya basıp oluşturucuyu oluştur deyince oluşur
        {
            _headingDal = headingDal;
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            // heading.HeadingStatus = false;//status false yap --> sağlıksız işlem
            _headingDal.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}

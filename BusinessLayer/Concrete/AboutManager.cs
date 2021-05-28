using BusinessLayer.Abstract;//aboutservice sonucu oluşan
using DataAccsessLayer.Abstract;//ICategoryService sonucu oluşan kütüphane
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _AboutDal.Insert(about);//abouttan gelen değeri ekle
        }

        public void AboutDelete(About about)
        {
            _AboutDal.Delete(about);//abouttan gelen değeri sil
        }

        public void AboutUpdate(About about)
        {
            _AboutDal.Update(about);//abouttan gelen değeri güncelle
        }

        public About GetByID(int id)
        {
            return _AboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _AboutDal.List();
        }
    }
}

using BusinessLayer.Abstract;//1.hata 
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService//kalıtımsal yolla üstüne aldı ve ımplements ile 2.hatada kalktı
    {
        IContentDal _contentdal;  //ıcategorydaldan üret _categorydal adında hata için en sonuncu çıkacak

        //categorymanagere gelip ctrl noktaya basıp oluşturucuyu oluştur deyince alttaki oluştu
        public ContentManager(IContentDal contentdal)
        {
            _contentdal = contentdal;
        }

        public List<Content> GetListByID(int id)
        {
            return _contentdal.List(x => x.HeadingID == id);
        }

       

        void IContentService.ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        void IContentService.ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        void IContentService.ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        Category IContentService.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Content> IContentService.GetList()
        {
            throw new NotImplementedException();
        }
    }
}

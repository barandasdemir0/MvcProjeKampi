using EntityLayer.Concrete;//content yerine çıkan hata için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();//category listesini getir yada listeyi getir
        List<Content> GetListByID(int id);//ıdye göre bana yüm listeyi döndür
        void ContentAdd(Content content);
        //burada bunu tanımladık Contentmanagerden çağırabilmemiz için burada Content ekle Content sınıfından Content ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        Category GetByID(int id);//Content adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık genericde ise single for demiştik ya işte orada buna göre işlem yapacak
        void ContentDelete(Content content);//void türünde Contentdelete adında ismin de bir metot Content sınıfından Content parametresi alacaksın
        void ContentUpdate(Content content);////void türünde ContentUpdate adında ismin de bir metot Content sınıfından Content parametresi alacaksın 
    }
}

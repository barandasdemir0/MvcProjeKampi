using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();//About listesini getir yada listeyi getir
        void AboutAdd(About about);
        //burada bunu tanımladık Aboutmanagerden çağırabilmemiz için burada About ekle About sınıfından About ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        About GetByID(int id);//About adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık genericde ise single for demiştik ya işte orada buna göre işlem yapacak
        void AboutDelete(About about);//void türünde Aboutdelete adında ismin de bir metot About sınıfından About parametresi alacaksın
        void AboutUpdate(About about);////void türünde AboutUpdate adında ismin de bir metot About sınıfından About parametresi alacaksın    
    }
}

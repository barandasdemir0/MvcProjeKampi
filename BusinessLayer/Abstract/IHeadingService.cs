using EntityLayer.Concrete;//headinglerde veren hata
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();//Heading listesini getir yada listeyi getir
        void HeadingAdd(Heading heading);
        //burada bunu tanımladık Headingmanagerden çağırabilmemiz için burada Heading ekle category sınıfından category ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        Heading GetByID(int id);//Heading adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık genericde ise single for demiştik ya işte orada buna göre işlem yapacak
        void HeadingDelete(Heading heading);//void türünde Headingdelete adında ismin de bir metot Heading sınıfından Heading parametresi alacaksın
        void HeadingUpdate(Heading heading);////void türünde HeadingUpdate adında ismin de bir metot Heading sınıfından Heading parametresi alacaksın    
    }
}

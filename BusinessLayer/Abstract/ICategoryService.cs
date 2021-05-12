using EntityLayer.Concrete;//bunun sayesinde categorynin altındaki hata kalktı
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();//category listesini getir yada listeyi getir
        void CategoryAdd(Category category);
        //burada bunu tanımladık categorymanagerden çağırabilmemiz için burada category ekle category sınıfından category ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        Category GetByID(int id);//category adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık genericde ise single for demiştik ya işte orada buna göre işlem yapacak
        void CategoryDelete(Category category);//void türünde categorydelete adında ismin de bir metot category sınıfından category parametresi alacaksın
        void CategoryUpdate(Category category);////void türünde CategoryUpdate adında ismin de bir metot category sınıfından category parametresi alacaksın    
    }
}

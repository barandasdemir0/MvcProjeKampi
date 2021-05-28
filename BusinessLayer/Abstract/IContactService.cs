using EntityLayer.Concrete;//hataları kaldırmak için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();//Contact listesini getir yada listeyi getir
        void ContactAdd(Contact contact);
        //burada bunu tanımladık Contactmanagerden çağırabilmemiz için burada Contact ekle Contact sınıfından Contact ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        Contact GetByID(int id);//Contact adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık genericde ise single for demiştik ya işte orada buna göre işlem yapacak
        void ContactDelete(Contact contact);//void türünde Contactdelete adında ismin de bir metot Contact sınıfından category parametresi alacaksın
        void ContactUpdate(Contact contact);////void türünde ContactUpdate adında ismin de bir metot Contact sınıfından Contact parametresi alacaksın   
    }
}

using EntityLayer.Concrete;//<> içinde oluşan hatalar için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IMessageService
    {
        List<Message> GetList();//Message listesini getir yada listeyi getir
        void MessageAdd(Message message);
        //burada bunu tanımladık Messagemanagerden çağırabilmemiz için burada Message ekle category sınıfından Message ürettik
        //burada bulma işlemi için gerekli komutları yazacağız aşşağıda
        Message GetByID(int id);//Message adında getbyıd isminde isim yazdık sen bir id alacaksın yani id ye göre işlem alacağmızı buraya yazdık
        void MessageDelete(Message message);//void türünde Messagedelete adında ismin de bir metot Message sınıfından Message parametresi alacaksın
        void MessageUpdate(Message message);////void türünde MessageUpdate adında ismin de bir metot Message sınıfından Message parametresi alacaksın    
    }
}

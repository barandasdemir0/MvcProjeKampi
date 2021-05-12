using EntityLayer.Concrete;//bu kütüphaneyi eklemezsek hata verir bunuda yazdıktan sonra hata düzeltici sayesinde otomatik ekleriz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    //BU YANLIŞ KULLANIM 100 TABLO OLSA 100 TABLODA BU MU YAPILACAK AMA BİZ NAPIYORUZ ÖRNEK OLMASI ADINA BUNU KOYUYORUZ IREPOSİTORY normal olan bu örnek

    //alttaki veriler silmedik örnek olarak ama bu Irepository<category> yazmak zorundaydık
    public interface ICategoryDal : IRepository<Category>
    {
        //CRUD
        //typename();

        // AŞŞAĞIDAKİ YÖNTEM YUKARIDA DA DEDİĞİMİZ GİBİ YANLIŞ ÖRNEKTİR

        //List<Category> List(); //listeleme işlemi için türü list olan ismide list olan bir method tanımladık

        //void Insert(Category p);//ekleme işlemi yapılır neye göre yapılır p aracılığı ile category sınıfında yer alan tüm propertylerine erişim sağlarız

        //void Update(Category p);//Güncelleme işlemi yapılır neye göre yapılır p aracılığı ile category sınıfında yer alan tüm propertylerine erişim sağlarız

        //void Delete(Category p);//Silme işlemi yapılır neye göre yapılır p aracılığı ile category sınıfında yer alan tüm propertylerine erişim sağlarız
    }
}

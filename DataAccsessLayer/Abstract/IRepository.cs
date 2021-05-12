using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;//bunu eklemezsek expression hata verir zaten hata düzeltmede ekleyelimmi der ve kendliğinden ekler
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepository<T>//bu t değeri tür değerim olacak bir entity değeri karşılayacak hangi entity sen sqlden ne gönderiyorsan yazar başlık gönderi
    {
        List<T> List();// t listesinden değeri al t ne biz ne istersek
        void Insert(T p); // t den ekle p değeri olarak t ne biz ne istersek
        T Get(Expression<Func<T, bool>> filter);//get adında değer tanımladık metot tanımladık list isimli metot t get metodunun adı t yanı entity
        void Delete(T p); // t den sil p değeri olarak t ne biz ne istersek
        void Update(T p); // t den güncelle p değeri olarak t ne biz ne istersek
        List<T> List(Expression<Func<T, bool>> filter);
        //burada şartlı listeleme yaptık bu method filtreleme yapar ve her oluşturduğumuzu kapsar
    }
}

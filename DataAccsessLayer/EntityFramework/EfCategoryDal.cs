using DataAccsessLayer.Abstract;//ıcategorydal hata düzeltme sonucu eklendi
using DataAccsessLayer.Concrete.Repositories;//generic repository hata düzeltme sonucu bu kütüphane ekleniyor
using EntityLayer.Concrete;//catrgory hata düzeltme sonucu bu eklendi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    //sen genericrepositoryden miras alacaksın ben buraya bir sınıf göndermeliyim category sınıfıyla çalışcağımızdan cateogry gönderdik
    //genel kodu toplarsak entitycategory dal generic repositorydeki category den ıcategorydalda ki komutları çekecek
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}

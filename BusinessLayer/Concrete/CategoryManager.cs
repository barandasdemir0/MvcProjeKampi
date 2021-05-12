using BusinessLayer.Abstract;//bunun sayesinde 1.hata kalkıyor
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Repositories;//generic repository deyince hata çıkacak ve hatayı böyle düzeltecez bu kütüphane eklenecek
using EntityLayer.Concrete;//category yazıp hatayı düzelt deyince bu kütüphane eklenecek
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService//kalıtımsal yolla üstüne aldı ve ımplements ile 2.hatada kalktı
    {
        ICategoryDal _categorydal;  //ıcategorydaldan üret _categorydal adında hata için en sonuncu çıkacak
        //categorymanagere gelip ctrl noktaya basıp oluşturucuyu oluştur deyince alttaki oluştu
        public CategoryManager(ICategoryDal categorydal)//categorymanagere ait sınıfım oluştu
        {
            _categorydal = categorydal;
        }
        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);//categoryi eklet şimdi categoryvalidatoru çağırmamız lazım bunuda controllerdan halledeceğiz hangi controller category controller
        }
        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);//idme esit olan categoryi komple sildi
        }
        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);//categoryden gelen değeri update uygulayacaksın
        }
        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
            //idden gelen değeri eşit olup olmadığını burada sorgulayacak
        }
        // YANLIŞ YÖNTEM AŞŞAĞIDA
        //
        // GenericRepository<Category> repo = new GenericRepository<Category>();//biz burada generic repositoryi çağırıp içine categori gönderdik

        //public List<Category> GetAll()//listeleme işlemi yaptık
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)  //eğer bu değerlerse hata mesajı gönderecek neyse işte categori adı boş ise 3 ten küçükse ve ya açıklaması boş ise veya name 51den büyük ise hata mesajı
        //    {
        //        // hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);//parametreden gelen değer eklensin
        //    }
        //}
        public List<Category> GetList()
        {
            return _categorydal.List();
        }
    }
}
//ctrl + k + d yaptığımız takdirde kodu düzenler

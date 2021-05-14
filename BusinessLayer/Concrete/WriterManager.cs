using BusinessLayer.Abstract;//IWriterService sonucu eklenen kütüphane
using DataAccsessLayer.Abstract;//IWriterDal sonucu eklenen kütüphane
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        //construcotr metod oluşturuyoruz burada nedeni istedğimiz arabirime yani interface ulaşalım ki atamaları istediğimiz formatta gerçekleştirelim
        IWriterDal  _writerDal;

        public WriterManager(IWriterDal writerDal)//bunun oluşması için writermanager deyip oluşturucuyu oluştur deyip tamama basmak lazım böylelikle burası oluşur
        {
            _writerDal = writerDal;
        }

        //aşağıdaki metotları arabirim uyguladık ve oluştu bunları servicede hani tanıtmıştık
        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID==id);
            //bana değer döndür ne değeri x öyle ki x writer id neye eşit olacak yukarıda döndürdüğümüz writer ıd
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();//listeleme metodunu çağırdık
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);//sen burada ekle neyi ekle writerı
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);//sen burada sil neyi sil writerı
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);//sen burada güncelle neyi güncelle writerı
        }
    }
}

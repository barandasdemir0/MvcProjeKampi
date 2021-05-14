using EntityLayer.Concrete;//writer dememiz sonucunda eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList(); //tümünü listeledik 
        void WriterAdd(Writer writer);//writer add oluşturduk writer sınıfından writer adında yani writer ekleyecek writer sınıfından alacak writer adında alacak
        void WriterDelete(Writer writer);//writer delete oluşturduk writer sınıfından writer adında yani writer silecek writer sınıfından alacak writer adında alacak
        void WriterUpdate(Writer writer);//writer update oluşturduk writer sınıfından writer adında yani writer güncelleyecek writer sınıfından alacak writer adında alacak
        Writer GetByID(int id);//idye göre getirmesi için bunu yazdık
    }
}

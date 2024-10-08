using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> ListTGetir();
        void TEkle(T t);
        void TSil(T t);
        void TGuncelle(T t);
        T IDGoreGetir(int id);
    }
}

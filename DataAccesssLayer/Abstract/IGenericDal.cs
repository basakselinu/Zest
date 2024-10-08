using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        List<T> ListTGetir();
        void TEkle(T t);
        void TSil(T t);
        void TGuncelle(T t);
        T IDGoreGetir(int id);
        List<T> ListTGetir(Expression<Func<T, bool>> filter);

    }
}

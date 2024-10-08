using DataAccesssLayer.Abstract;
using DataAccesssLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
     
        public T IDGoreGetir(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> ListTGetir(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public List<T> ListTGetir()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void TEkle(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void TGuncelle(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

        public void TSil(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
    }
}

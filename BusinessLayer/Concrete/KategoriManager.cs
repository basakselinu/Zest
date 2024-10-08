using BusinessLayer.Abstract;
using DataAccesssLayer.Abstract;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;   
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori IDGoreGetir(int id)
        {
            return _kategoriDal.IDGoreGetir(id);
        }
        public List<Kategori> ListKategoriGetir()
        {
            return _kategoriDal.ListTGetir();
        }
        public List<Kategori> ListTGetir()
        {
            return _kategoriDal.ListTGetir();
        }
        public void TEkle(Kategori t)
        {
            _kategoriDal.TEkle(t);
        }
        public void TGuncelle(Kategori t)
        {
            _kategoriDal.TGuncelle(t);
        }
        public void TSil(Kategori t)
        {
            _kategoriDal.TSil(t);
        }
    }
}

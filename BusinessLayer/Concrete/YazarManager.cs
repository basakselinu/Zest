using BusinessLayer.Abstract;
using DataAccesssLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class YazarManager : IYazarService
    {
        IYazarDal _yazarDal;

        public YazarManager(IYazarDal yazarDal)
        {
            _yazarDal = yazarDal;
        }

        public Yazar IDGoreGetir(int id)
        {
            return _yazarDal.IDGoreGetir(id);
        }

        public List<Yazar> IDGoreYazarGetir(int id)
        {
            return _yazarDal.ListTGetir(x => x.YazarID == id);
        }

        public List<Yazar> ListTGetir()
        {
            throw new NotImplementedException();
        }

        public void TEkle(Yazar t)
        {
            _yazarDal.TEkle(t);
        }

        public void TGuncelle(Yazar t)
        {
            _yazarDal.TGuncelle(t);
        }

        public void TSil(Yazar t)
        {
            _yazarDal.TSil(t);
        }
    }
}

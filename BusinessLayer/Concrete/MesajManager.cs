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
    public class MesajManager : IMesajService
    {
        IMesajDal _mesajDal;

        public MesajManager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public Mesaj IDGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> ListTGetir()
        {
            return _mesajDal.ListTGetir();
        }

        public void TEkle(Mesaj t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Mesaj t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Mesaj t)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> YazarİleInboxListeGetir(string s)
        {
            return _mesajDal.ListTGetir(x => x.MesajAlan == s);
        }
    }
}

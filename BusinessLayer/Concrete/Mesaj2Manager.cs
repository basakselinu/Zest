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
    public class Mesaj2Manager : IMesaj2Service
    {
        IMesaj2Dal _mesaj2Dal;

        public Mesaj2Manager(IMesaj2Dal mesaj2Dal)
        {
            _mesaj2Dal = mesaj2Dal;
        }

        public Mesaj2 IDGoreGetir(int id)
        {
            return _mesaj2Dal.IDGoreGetir(id);
        }

        public List<Mesaj2> ListTGetir()
        {
            return _mesaj2Dal.ListTGetir();
        }

        public void TEkle(Mesaj2 t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Mesaj2 t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Mesaj2 t)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj2> YazarİleInboxListeGetir(int id)
        {
            return _mesaj2Dal.YazaraGoreMesajİleListeyiGetir(id);
        }
    }
}

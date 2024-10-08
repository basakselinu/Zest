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
    public class BildirimManager : IBildirimService
    {
        IBildirimDal _bildirimDal;

        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }

        public Bildirim IDGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bildirim> ListTGetir()
        {
            return _bildirimDal.ListTGetir();
        }

        public void TEkle(Bildirim t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Bildirim t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Bildirim t)
        {
            throw new NotImplementedException();
        }
    }
}

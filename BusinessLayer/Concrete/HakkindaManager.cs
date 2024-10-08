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
    public class HakkindaManager : IHakkindaService
    {
        IHakkindaDal _hakkindaDal;

        public HakkindaManager(IHakkindaDal hakkindaDal)
        {
            _hakkindaDal = hakkindaDal;
        }

        public Hakkinda IDGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkinda> ListHakkindaGetir()
        {
            return _hakkindaDal.ListTGetir();
        }

        public List<Hakkinda> ListTGetir()
        {
            throw new NotImplementedException();
        }

        public void TEkle(Hakkinda t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Hakkinda t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Hakkinda t)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin IDGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> ListTGetir()
        {
            throw new NotImplementedException();
        }

        public void TEkle(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TSil(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}

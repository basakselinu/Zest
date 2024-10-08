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
    public class DuyurularManager : IDuyurularService
    {
        IDuyurularDal _duyurularDal;

        public DuyurularManager(IDuyurularDal duyurularDal)
        {
            _duyurularDal = duyurularDal;
        }

        public void DuyurularEkle(Duyurular duyurular)
        {
            _duyurularDal.TEkle(duyurular);
        }
    }
}

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
    public class IletisimManager : IIletisimService
    {
        IIletisimDal _ıletisimDal;

        public IletisimManager(IIletisimDal ıletisimDal)
        {
            _ıletisimDal = ıletisimDal;
        }

        public void IletisimEkle(Iletisim ıletisim)
        {
            _ıletisimDal.TEkle(ıletisim);
        }
    }
}

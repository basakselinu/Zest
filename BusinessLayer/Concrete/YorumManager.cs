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
    public class YorumManager : IYorumService
    {
        IYorumDal _yorumDal;

        public YorumManager(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }

        public List<Yorum> ListYorumGetir(int id)
        {
            return _yorumDal.ListTGetir(x => x.BlogID == id);
        }

        public void YorumEkle(Yorum yorum)
        {
            _yorumDal.TEkle(yorum);
        }
    }
}

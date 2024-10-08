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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public Blog IDGoreGetir(int id)
        {
            return _blogDal.IDGoreGetir(id);
        }
        public List<Blog> IDGoreBlogGetir(int id)
        {
            return _blogDal.ListTGetir(x=>x.BlogID==id);
        }

        public List<Blog> KategoriİleListeyiGetir()
        {
            return _blogDal.KategoriİleListeyiGetir();
        }
        public List<Blog> YazaraGoreKategoriİleListeyiGetirBM(int id)
        {
            return _blogDal.YazaraGoreKategoriİleListeyiGetir(id);
        }
    

        public List<Blog> ListBlogGetir()
        {
            return _blogDal.ListTGetir();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.ListTGetir().Take(3).ToList();
        }

        public List<Blog> YazarİleBlogList(int id)
        {
            return _blogDal.ListTGetir(x => x.YazarID == id);
        }

        public List<Blog> ListTGetir()
        {
            return _blogDal.ListTGetir();
        }

        public void TEkle(Blog t)
        {
            _blogDal.TEkle(t);
        }

        public void TSil(Blog t)
        {
            _blogDal.TSil(t);
        }

        public void TGuncelle(Blog t)
        {
            _blogDal.TGuncelle(t);
        }
    }
}

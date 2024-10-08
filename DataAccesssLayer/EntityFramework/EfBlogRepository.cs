using DataAccesssLayer.Abstract;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> KategoriİleListeyiGetir()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Kategori).ToList();
            }
        }

        public List<Blog> YazaraGoreKategoriİleListeyiGetir(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Kategori).Where(x => x.YazarID == id).ToList();
            }
        }
    }
}

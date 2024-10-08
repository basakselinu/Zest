using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BASAKSELIN; database=ZestDb; " +
                "Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesaj2>()
                .HasOne(x => x.GonderenKullanici)
                .WithMany(y => y.MesajGonderen)
                .HasForeignKey(z => z.MesajGonderenID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mesaj2>()
                .HasOne(x => x.AlanKullanici)
                .WithMany(y => y.MesajAlan)
                .HasForeignKey(z => z.MesajAlanID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Hakkinda> Hakkindas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Duyurular> Duyurulars { get; set; }
        public DbSet<BlogDegerlendirme> blogDegerlendirmes { get; set; }
        public DbSet<Bildirim> Bildirims { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        public DbSet<Mesaj2> Mesaj2s { get; set; }
        public DbSet<Admin> Admins { get; set; }



    }
}

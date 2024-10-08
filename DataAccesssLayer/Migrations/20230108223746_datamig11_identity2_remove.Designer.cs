﻿// <auto-generated />
using System;
using DataAccesssLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccesssLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230108223746_datamig11_identity2_remove")]
    partial class datamig11_identity2_remove
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminAcıklamakısa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminKullanıcıAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminResimURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bildirim", b =>
                {
                    b.Property<int>("BildirimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BildirimDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BildirimDurum")
                        .HasColumnType("bit");

                    b.Property<string>("BildirimRenk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildirimSembol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BildirimTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("BildirimTuru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BildirimID");

                    b.ToTable("Bildirims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogDurum")
                        .HasColumnType("bit");

                    b.Property<string>("BlogKapakResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BlogTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Blogİcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("YazarID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogDegerlendirme", b =>
                {
                    b.Property<int>("BlogDegerlendirmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogDegerlendirmeSayisi")
                        .HasColumnType("int");

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("BlogToplamPuan")
                        .HasColumnType("int");

                    b.HasKey("BlogDegerlendirmeID");

                    b.ToTable("blogDegerlendirmes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Duyurular", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailDurum")
                        .HasColumnType("bit");

                    b.HasKey("MailID");

                    b.ToTable("Duyurulars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hakkinda", b =>
                {
                    b.Property<int>("HakkindaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HakkindaDetay1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaDetay2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HakkindaDurum")
                        .HasColumnType("bit");

                    b.Property<string>("HakkindaHarita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaResim1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkindaResim2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkindaID");

                    b.ToTable("Hakkindas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Iletisim", b =>
                {
                    b.Property<int>("IletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IletisimBaslık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IletisimDurum")
                        .HasColumnType("bit");

                    b.Property<string>("IletisimIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimKullanıcıAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IletisimTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("IletisimID");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KategoriDurum")
                        .HasColumnType("bit");

                    b.Property<string>("KategoriTanimlama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MesajAlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajDurum")
                        .HasColumnType("bit");

                    b.Property<string>("MesajGonderen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajKonusu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj2", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MesajAlanID")
                        .HasColumnType("int");

                    b.Property<string>("MesajDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajDurum")
                        .HasColumnType("bit");

                    b.Property<int?>("MesajGonderenID")
                        .HasColumnType("int");

                    b.Property<string>("MesajKonusu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.HasIndex("MesajAlanID");

                    b.HasIndex("MesajGonderenID");

                    b.ToTable("Mesaj2s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YazarAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarBilgi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YazarDurum")
                        .HasColumnType("bit");

                    b.Property<string>("YazarMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("BlogPuan")
                        .HasColumnType("int");

                    b.Property<string>("YorumBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YorumDurum")
                        .HasColumnType("bit");

                    b.Property<string>("YorumIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("YorumYapanAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("BlogID");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kategori", "Kategori")
                        .WithMany("Blogs")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Yazar", "Yazar")
                        .WithMany("Blogs")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj2", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Yazar", "AlanKullanici")
                        .WithMany("MesajAlan")
                        .HasForeignKey("MesajAlanID");

                    b.HasOne("EntityLayer.Concrete.Yazar", "GonderenKullanici")
                        .WithMany("MesajGonderen")
                        .HasForeignKey("MesajGonderenID");

                    b.Navigation("AlanKullanici");

                    b.Navigation("GonderenKullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yorum", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("Yorums")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("Yorums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yazar", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("MesajAlan");

                    b.Navigation("MesajGonderen");
                });
#pragma warning restore 612, 618
        }
    }
}

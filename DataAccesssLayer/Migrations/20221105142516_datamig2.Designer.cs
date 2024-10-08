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
    [Migration("20221105142516_datamig2")]
    partial class datamig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasKey("BlogID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Blogs");
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

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kategori", "Kategori")
                        .WithMany("Blogs")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kategori", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}

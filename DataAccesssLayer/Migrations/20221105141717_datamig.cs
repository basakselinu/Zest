using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blogİcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogKapakResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkindas",
                columns: table => new
                {
                    HakkindaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkindaDetay1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaDetay2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaResim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaResim2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaHarita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkindaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkindas", x => x.HakkindaID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    IletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimKullanıcıAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimBaslık = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IletisimDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.IletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriTanimlama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarBilgi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumYapanAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YorumDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.YorumID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Hakkindas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Yazars");

            migrationBuilder.DropTable(
                name: "Yorums");
        }
    }
}

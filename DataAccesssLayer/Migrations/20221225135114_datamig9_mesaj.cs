using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig9_mesaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesajs",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajGonderen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajAlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajKonusu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajs", x => x.MesajID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesajs");
        }
    }
}

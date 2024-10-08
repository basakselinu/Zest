using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig9_mesaj2_iliskiler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesaj2s",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajGonderenID = table.Column<int>(type: "int", nullable: true),
                    MesajAlanID = table.Column<int>(type: "int", nullable: true),
                    MesajKonusu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesaj2s", x => x.MesajID);
                    table.ForeignKey(
                        name: "FK_Mesaj2s_Yazars_MesajAlanID",
                        column: x => x.MesajAlanID,
                        principalTable: "Yazars",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mesaj2s_Yazars_MesajGonderenID",
                        column: x => x.MesajGonderenID,
                        principalTable: "Yazars",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mesaj2s_MesajAlanID",
                table: "Mesaj2s",
                column: "MesajAlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Mesaj2s_MesajGonderenID",
                table: "Mesaj2s",
                column: "MesajGonderenID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesaj2s");
        }
    }
}

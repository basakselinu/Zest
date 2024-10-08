using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_KategoriID",
                table: "Blogs",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Kategoris_KategoriID",
                table: "Blogs",
                column: "KategoriID",
                principalTable: "Kategoris",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Kategoris_KategoriID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_KategoriID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Blogs");
        }
    }
}

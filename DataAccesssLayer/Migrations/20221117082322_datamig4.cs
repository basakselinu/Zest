using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YazarID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_YazarID",
                table: "Blogs",
                column: "YazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Yazars_YazarID",
                table: "Blogs",
                column: "YazarID",
                principalTable: "Yazars",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Yazars_YazarID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_YazarID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "YazarID",
                table: "Blogs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesssLayer.Migrations
{
    public partial class datamig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Yorums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_BlogID",
                table: "Yorums",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorums_Blogs_BlogID",
                table: "Yorums",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorums_Blogs_BlogID",
                table: "Yorums");

            migrationBuilder.DropIndex(
                name: "IX_Yorums_BlogID",
                table: "Yorums");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Yorums");
        }
    }
}

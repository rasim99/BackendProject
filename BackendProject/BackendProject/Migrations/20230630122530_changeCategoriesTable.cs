using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class changeCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BottomImageUrl",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BottomTitle",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "TopTitle",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TopImageUrl",
                table: "Categories",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "TopTitle");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Categories",
                newName: "TopImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "BottomImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BottomTitle",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class AddProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarCount = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BottomFirstImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BottomSecondImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BottomStarCount = table.Column<int>(type: "int", nullable: false),
                    BottomTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BottomPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

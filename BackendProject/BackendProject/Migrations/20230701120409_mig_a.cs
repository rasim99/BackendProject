using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    public partial class mig_a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductMenu_ProductMenus_ProductMenuId",
                table: "ProductProductMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductMenu_Products_ProductId",
                table: "ProductProductMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductMenu",
                table: "ProductProductMenu");

            migrationBuilder.RenameTable(
                name: "ProductProductMenu",
                newName: "ProductProductMenus");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProductMenu_ProductMenuId",
                table: "ProductProductMenus",
                newName: "IX_ProductProductMenus_ProductMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProductMenu_ProductId",
                table: "ProductProductMenus",
                newName: "IX_ProductProductMenus_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductMenus",
                table: "ProductProductMenus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductMenus_ProductMenus_ProductMenuId",
                table: "ProductProductMenus",
                column: "ProductMenuId",
                principalTable: "ProductMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductMenus_Products_ProductId",
                table: "ProductProductMenus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductMenus_ProductMenus_ProductMenuId",
                table: "ProductProductMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductMenus_Products_ProductId",
                table: "ProductProductMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProductMenus",
                table: "ProductProductMenus");

            migrationBuilder.RenameTable(
                name: "ProductProductMenus",
                newName: "ProductProductMenu");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProductMenus_ProductMenuId",
                table: "ProductProductMenu",
                newName: "IX_ProductProductMenu_ProductMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProductMenus_ProductId",
                table: "ProductProductMenu",
                newName: "IX_ProductProductMenu_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProductMenu",
                table: "ProductProductMenu",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductMenu_ProductMenus_ProductMenuId",
                table: "ProductProductMenu",
                column: "ProductMenuId",
                principalTable: "ProductMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductMenu_Products_ProductId",
                table: "ProductProductMenu",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

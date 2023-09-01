using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorHotelH2.Migrations
{
    /// <inheritdoc />
    public partial class MakeAdminAndCustomerNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Administrators_administratorsadminId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_customerscustomerId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "customerscustomerId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "administratorsadminId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Administrators_administratorsadminId",
                table: "Users",
                column: "administratorsadminId",
                principalTable: "Administrators",
                principalColumn: "adminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_customerscustomerId",
                table: "Users",
                column: "customerscustomerId",
                principalTable: "Customers",
                principalColumn: "customerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Administrators_administratorsadminId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_customerscustomerId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "customerscustomerId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "administratorsadminId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Administrators_administratorsadminId",
                table: "Users",
                column: "administratorsadminId",
                principalTable: "Administrators",
                principalColumn: "adminId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_customerscustomerId",
                table: "Users",
                column: "customerscustomerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

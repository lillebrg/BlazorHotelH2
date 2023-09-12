using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class FixedPictureIdAndEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "PictureId",
                table: "Picture",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "EMail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Picture",
                newName: "PictureId");
        }
    }
}

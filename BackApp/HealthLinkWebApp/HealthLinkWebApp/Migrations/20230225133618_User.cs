using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthLinkWebApp.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilPhotoName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilPhotoNameInFileSystem",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilPhotoName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilPhotoNameInFileSystem",
                table: "Users");
        }
    }
}

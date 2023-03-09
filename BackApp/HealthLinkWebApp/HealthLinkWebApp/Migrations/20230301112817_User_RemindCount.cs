using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthLinkWebApp.Migrations
{
    /// <inheritdoc />
    public partial class User_RemindCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RemindCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemindCount",
                table: "Products");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthLinkWebApp.Migrations
{
    /// <inheritdoc />
    public partial class About : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeftImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeftImageNameInFileSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightImageNameInFileSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}

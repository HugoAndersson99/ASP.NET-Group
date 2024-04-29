using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_GruppUPG.Migrations
{
    /// <inheritdoc />
    public partial class addedToSeries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Serie",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Episodes",
                table: "Serie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Serie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seasons",
                table: "Serie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Serie",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "Episodes",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "Seasons",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Serie");
        }
    }
}

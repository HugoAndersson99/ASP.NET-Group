using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_GruppUPG.Migrations
{
    /// <inheritdoc />
    public partial class Databse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

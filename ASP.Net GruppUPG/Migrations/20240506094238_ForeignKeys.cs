using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net_GruppUPG.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaUserMovie",
                columns: table => new
                {
                    MoviesInLibraryMovieId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaUserMovie", x => new { x.MoviesInLibraryMovieId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MediaUserMovie_MediaUser_UsersId",
                        column: x => x.UsersId,
                        principalTable: "MediaUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaUserMovie_Movie_MoviesInLibraryMovieId",
                        column: x => x.MoviesInLibraryMovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MediaUserSerie",
                columns: table => new
                {
                    SeriesInLibrarySerieId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaUserSerie", x => new { x.SeriesInLibrarySerieId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MediaUserSerie_MediaUser_UsersId",
                        column: x => x.UsersId,
                        principalTable: "MediaUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaUserSerie_Serie_SeriesInLibrarySerieId",
                        column: x => x.SeriesInLibrarySerieId,
                        principalTable: "Serie",
                        principalColumn: "SerieId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MediaUserMovie_UsersId",
                table: "MediaUserMovie",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaUserSerie_UsersId",
                table: "MediaUserSerie",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaUserMovie");

            migrationBuilder.DropTable(
                name: "MediaUserSerie");
        }
    }
}

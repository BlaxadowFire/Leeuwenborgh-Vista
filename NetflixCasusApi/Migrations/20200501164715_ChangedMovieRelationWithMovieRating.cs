using Microsoft.EntityFrameworkCore.Migrations;

namespace NetflixCasusApi.Migrations
{
    public partial class ChangedMovieRelationWithMovieRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRating_Movie_MovieId",
                table: "MovieRating");

            migrationBuilder.DropIndex(
                name: "IX_MovieRating_MovieId",
                table: "MovieRating");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieRating");

            migrationBuilder.CreateTable(
                name: "MovieMovieRating",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    MovieRatingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieRating", x => new { x.MovieId, x.MovieRatingId });
                    table.ForeignKey(
                        name: "FK_MovieMovieRating_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieRating_MovieRating_MovieRatingId",
                        column: x => x.MovieRatingId,
                        principalTable: "MovieRating",
                        principalColumn: "MovieRatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieRating_MovieRatingId",
                table: "MovieMovieRating",
                column: "MovieRatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieMovieRating");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MovieRating",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieRating_MovieId",
                table: "MovieRating",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRating_Movie_MovieId",
                table: "MovieRating",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class fix_movies_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Moives_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Moives_Cinemas_CinemaId",
                table: "Moives");

            migrationBuilder.DropForeignKey(
                name: "FK_Moives_Producers_ProducerId",
                table: "Moives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moives",
                table: "Moives");

            migrationBuilder.RenameTable(
                name: "Moives",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Moives_ProducerId",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Moives_CinemaId",
                table: "Movies",
                newName: "IX_Movies_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Moives");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Moives",
                newName: "IX_Moives_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CinemaId",
                table: "Moives",
                newName: "IX_Moives_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moives",
                table: "Moives",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Moives_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Moives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moives_Cinemas_CinemaId",
                table: "Moives",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moives_Producers_ProducerId",
                table: "Moives",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

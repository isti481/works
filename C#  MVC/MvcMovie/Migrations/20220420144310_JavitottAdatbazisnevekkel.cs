using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class JavitottAdatbazisnevekkel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Releasedate",
                table: "Movie",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Movie",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "Releasedate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "MyProperty");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class InisialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "Gendre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Gendre",
                table: "Movie",
                newName: "Genre");
        }
    }
}

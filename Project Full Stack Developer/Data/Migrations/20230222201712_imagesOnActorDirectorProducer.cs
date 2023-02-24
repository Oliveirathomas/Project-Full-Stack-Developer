using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Full_Stack_Developer.Data.Migrations
{
    public partial class imagesOnActorDirectorProducer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgPath",
                table: "Prodution",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imgPath",
                table: "Director",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imgPath",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgPath",
                table: "Prodution");

            migrationBuilder.DropColumn(
                name: "imgPath",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "imgPath",
                table: "Actor");
        }
    }
}

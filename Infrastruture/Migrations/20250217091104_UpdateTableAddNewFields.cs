using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableAddNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Anciao",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Missionario",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OutraOvelha",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PioneiroEspecial",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PioneiroRegular",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ServoMinisterial",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ungido",
                table: "Publicador",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anciao",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "Missionario",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "OutraOvelha",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "PioneiroEspecial",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "PioneiroRegular",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "ServoMinisterial",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "Ungido",
                table: "Publicador");
        }
    }
}

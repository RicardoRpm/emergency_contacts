using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Publicador",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Publicador",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Publicador",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Publicador",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Publicador");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Publicador");
        }
    }
}

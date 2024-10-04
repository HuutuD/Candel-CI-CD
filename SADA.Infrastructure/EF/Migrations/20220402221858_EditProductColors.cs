﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SADA.Infrastructure.EF.Migrations
{
    public partial class EditProductColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "ProductColor");

            migrationBuilder.AddColumn<int>(
                name: "B",
                table: "ProductColor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "G",
                table: "ProductColor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "R",
                table: "ProductColor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "B",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "G",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "R",
                table: "ProductColor");

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "ProductColor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class WordSpellingUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Spelling",
                table: "Words",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Words_Spelling",
                table: "Words",
                column: "Spelling",
                unique: true,
                filter: "[Spelling] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Words_Spelling",
                table: "Words");

            migrationBuilder.AlterColumn<string>(
                name: "Spelling",
                table: "Words",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class RemoveWordUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Words_Spelling_LanguageId",
                table: "Words");

            migrationBuilder.AlterColumn<string>(
                name: "Spelling",
                table: "Words",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Spelling",
                table: "Words",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Words_Spelling_LanguageId",
                table: "Words",
                columns: new[] { "Spelling", "LanguageId" },
                unique: true,
                filter: "[Spelling] IS NOT NULL");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class WordSpellingLanguageIdUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Words_Spelling",
                table: "Words");

            migrationBuilder.CreateIndex(
                name: "IX_Words_Spelling_LanguageId",
                table: "Words",
                columns: new[] { "Spelling", "LanguageId" },
                unique: true,
                filter: "[Spelling] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Words_Spelling_LanguageId",
                table: "Words");

            migrationBuilder.CreateIndex(
                name: "IX_Words_Spelling",
                table: "Words",
                column: "Spelling",
                unique: true,
                filter: "[Spelling] IS NOT NULL");
        }
    }
}

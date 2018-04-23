using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class VocabularyModelsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Words_LanguageId",
                table: "Words",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_WordToId",
                table: "Translations",
                column: "WordToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Words_WordFromId",
                table: "Translations",
                column: "WordFromId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Words_WordToId",
                table: "Translations",
                column: "WordToId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Languages_LanguageId",
                table: "Words",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Words_WordFromId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Words_WordToId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Languages_LanguageId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_LanguageId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Translations_WordToId",
                table: "Translations");
        }
    }
}

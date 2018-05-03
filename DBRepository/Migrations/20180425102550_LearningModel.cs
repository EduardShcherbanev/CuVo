using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class LearningModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_AspNetUsers_UserId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Words_WordFromId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Words_WordToId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_WordToId",
                table: "Translations");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Translations",
                newName: "UserWordToUserId");

            migrationBuilder.RenameColumn(
                name: "WordToId",
                table: "Translations",
                newName: "UserWordToId");

            migrationBuilder.RenameColumn(
                name: "WordFromId",
                table: "Translations",
                newName: "UserWordFromId");

            migrationBuilder.AddColumn<int>(
                name: "PartOfSpeechId",
                table: "Words",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserWordFromUserId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWordFromWordId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWordToWordId",
                table: "Translations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PartOfSpeech",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartOfSpeech", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartOfSpeech_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWords",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WordId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWords", x => new { x.UserId, x.WordId });
                    table.ForeignKey(
                        name: "FK_UserWords_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWords_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_PartOfSpeechId",
                table: "Words",
                column: "PartOfSpeechId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserWordFromUserId_UserWordFromWordId",
                table: "Translations",
                columns: new[] { "UserWordFromUserId", "UserWordFromWordId" });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserWordToUserId_UserWordToWordId",
                table: "Translations",
                columns: new[] { "UserWordToUserId", "UserWordToWordId" });

            migrationBuilder.CreateIndex(
                name: "IX_PartOfSpeech_LanguageId",
                table: "PartOfSpeech",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWords_WordId",
                table: "UserWords",
                column: "WordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_UserWords_UserWordFromUserId_UserWordFromWordId",
                table: "Translations",
                columns: new[] { "UserWordFromUserId", "UserWordFromWordId" },
                principalTable: "UserWords",
                principalColumns: new[] { "UserId", "WordId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_UserWords_UserWordToUserId_UserWordToWordId",
                table: "Translations",
                columns: new[] { "UserWordToUserId", "UserWordToWordId" },
                principalTable: "UserWords",
                principalColumns: new[] { "UserId", "WordId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_PartOfSpeech_PartOfSpeechId",
                table: "Words",
                column: "PartOfSpeechId",
                principalTable: "PartOfSpeech",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordFromUserId_UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordToUserId_UserWordToWordId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_PartOfSpeech_PartOfSpeechId",
                table: "Words");

            migrationBuilder.DropTable(
                name: "PartOfSpeech");

            migrationBuilder.DropTable(
                name: "UserWords");

            migrationBuilder.DropIndex(
                name: "IX_Words_PartOfSpeechId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserWordFromUserId_UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserWordToUserId_UserWordToWordId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "PartOfSpeechId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "UserWordFromUserId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordToWordId",
                table: "Translations");

            migrationBuilder.RenameColumn(
                name: "UserWordToUserId",
                table: "Translations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserWordToId",
                table: "Translations",
                newName: "WordToId");

            migrationBuilder.RenameColumn(
                name: "UserWordFromId",
                table: "Translations",
                newName: "WordFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserId",
                table: "Translations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_WordToId",
                table: "Translations",
                column: "WordToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_AspNetUsers_UserId",
                table: "Translations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Words_WordFromId",
                table: "Translations",
                column: "WordFromId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Words_WordToId",
                table: "Translations",
                column: "WordToId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

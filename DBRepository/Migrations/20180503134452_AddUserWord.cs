using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class AddUserWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordFromUserId_UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordToUserId_UserWordToWordId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWords_AspNetUsers_UserId",
                table: "UserWords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWords",
                table: "UserWords");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserWordFromUserId_UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserWordToUserId_UserWordToWordId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordFromUserId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordFromWordId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordToUserId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserWordToWordId",
                table: "Translations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserWords",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserWords",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWords",
                table: "UserWords",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserWords_UserId_WordId",
                table: "UserWords",
                columns: new[] { "UserId", "WordId" });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserWordToId",
                table: "Translations",
                column: "UserWordToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_UserWords_UserWordFromId",
                table: "Translations",
                column: "UserWordFromId",
                principalTable: "UserWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_UserWords_UserWordToId",
                table: "Translations",
                column: "UserWordToId",
                principalTable: "UserWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserWords_AspNetUsers_UserId",
                table: "UserWords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordFromId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_UserWords_UserWordToId",
                table: "Translations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserWords_AspNetUsers_UserId",
                table: "UserWords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserWords",
                table: "UserWords");

            migrationBuilder.DropIndex(
                name: "IX_UserWords_UserId_WordId",
                table: "UserWords");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserWordToId",
                table: "Translations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserWords",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserWords",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "UserWordFromUserId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWordFromWordId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserWordToUserId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserWordToWordId",
                table: "Translations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserWords",
                table: "UserWords",
                columns: new[] { "UserId", "WordId" });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserWordFromUserId_UserWordFromWordId",
                table: "Translations",
                columns: new[] { "UserWordFromUserId", "UserWordFromWordId" });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserWordToUserId_UserWordToWordId",
                table: "Translations",
                columns: new[] { "UserWordToUserId", "UserWordToWordId" });

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
                name: "FK_UserWords_AspNetUsers_UserId",
                table: "UserWords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

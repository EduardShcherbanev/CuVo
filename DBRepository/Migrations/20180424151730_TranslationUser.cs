using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuVo.DBRepository.Migrations
{
    public partial class TranslationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Translations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_UserId",
                table: "Translations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_AspNetUsers_UserId",
                table: "Translations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_AspNetUsers_UserId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_UserId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Translations");
        }
    }
}

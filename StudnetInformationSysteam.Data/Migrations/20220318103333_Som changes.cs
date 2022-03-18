using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudnetInformationSysteam.Data.Migrations
{
    public partial class Somchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_AspNetUsers_AppUserId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_AppUserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamDate",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "point",
                table: "Exams");

            migrationBuilder.AddColumn<double>(
                name: "Scoor",
                table: "UserExams",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scoor",
                table: "UserExams");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Exams",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDate",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "point",
                table: "Exams",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_AppUserId",
                table: "Exams",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_AspNetUsers_AppUserId",
                table: "Exams",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

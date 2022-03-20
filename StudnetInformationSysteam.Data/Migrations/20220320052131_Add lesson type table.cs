using Microsoft.EntityFrameworkCore.Migrations;

namespace StudnetInformationSysteam.Data.Migrations
{
    public partial class Addlessontypetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Lesssons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LessonTypeId",
                table: "Lesssons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Lesssons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LessonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesssons_AppUserId",
                table: "Lesssons",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesssons_LessonTypeId",
                table: "Lesssons",
                column: "LessonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesssons_AspNetUsers_AppUserId",
                table: "Lesssons",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesssons_LessonTypes_LessonTypeId",
                table: "Lesssons",
                column: "LessonTypeId",
                principalTable: "LessonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesssons_AspNetUsers_AppUserId",
                table: "Lesssons");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesssons_LessonTypes_LessonTypeId",
                table: "Lesssons");

            migrationBuilder.DropTable(
                name: "LessonTypes");

            migrationBuilder.DropIndex(
                name: "IX_Lesssons_AppUserId",
                table: "Lesssons");

            migrationBuilder.DropIndex(
                name: "IX_Lesssons_LessonTypeId",
                table: "Lesssons");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Lesssons");

            migrationBuilder.DropColumn(
                name: "LessonTypeId",
                table: "Lesssons");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Lesssons");
        }
    }
}

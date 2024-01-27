using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_LESSON_1_HOME_WORK_2.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupLectures_Curators_LectureId",
                table: "GroupLectures");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupLectures_Lectures_LectureId",
                table: "GroupLectures",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupLectures_Lectures_LectureId",
                table: "GroupLectures");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupLectures_Curators_LectureId",
                table: "GroupLectures",
                column: "LectureId",
                principalTable: "Curators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

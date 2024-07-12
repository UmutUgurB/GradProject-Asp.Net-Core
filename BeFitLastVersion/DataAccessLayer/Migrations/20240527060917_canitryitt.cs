using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class canitryitt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseProgramId",
                table: "Weeks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_ExerciseProgramId",
                table: "Weeks",
                column: "ExerciseProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_ExercisePrograms_ExerciseProgramId",
                table: "Weeks",
                column: "ExerciseProgramId",
                principalTable: "ExercisePrograms",
                principalColumn: "ExerciseProgramId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_ExercisePrograms_ExerciseProgramId",
                table: "Weeks");

            migrationBuilder.DropIndex(
                name: "IX_Weeks_ExerciseProgramId",
                table: "Weeks");

            migrationBuilder.DropColumn(
                name: "ExerciseProgramId",
                table: "Weeks");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    /// <inheritdoc />
    public partial class AddWorkoutRecordEntityUpdte1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CheatmealUpdatedDateTime",
                table: "WorkoutRecord",
                newName: "WorkoutRecordUpdatedDateTime");

            migrationBuilder.RenameColumn(
                name: "CheatmealAddedDateTime",
                table: "WorkoutRecord",
                newName: "WorkoutRecordAddedDateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkoutRecordUpdatedDateTime",
                table: "WorkoutRecord",
                newName: "CheatmealUpdatedDateTime");

            migrationBuilder.RenameColumn(
                name: "WorkoutRecordAddedDateTime",
                table: "WorkoutRecord",
                newName: "CheatmealAddedDateTime");
        }
    }
}

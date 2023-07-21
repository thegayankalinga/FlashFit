using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    /// <inheritdoc />
    public partial class AddWorkoutRecordEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutRecord",
                columns: table => new
                {
                    WorkoutRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_workouttypeid = table.Column<int>(type: "int", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkedoutDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightAtCompletion = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CheatmealAddedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheatmealUpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutRecord", x => x.WorkoutRecordId);
                    table.ForeignKey(
                        name: "FK_WorkoutRecord_WorkoutType_fk_workouttypeid",
                        column: x => x.fk_workouttypeid,
                        principalTable: "WorkoutType",
                        principalColumn: "WorkoutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutRecord_fk_workouttypeid",
                table: "WorkoutRecord",
                column: "fk_workouttypeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutRecord");
        }
    }
}

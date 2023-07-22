using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    /// <inheritdoc />
    public partial class AddWorkoutRecordEntityUpdte4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutRecord_WorkoutType_fk_workouttypeid",
                table: "WorkoutRecord");

            migrationBuilder.RenameColumn(
                name: "fk_workouttypeid",
                table: "WorkoutRecord",
                newName: "WorkoutTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutRecord_fk_workouttypeid",
                table: "WorkoutRecord",
                newName: "IX_WorkoutRecord_WorkoutTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "WorkoutRecord",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightInKiloGrams = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    HeightInCentiMeter = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BodyMassIndex = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    HealthStatus = table.Column<string>(type: "nvarchar(129)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Email);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutRecord_UserEmail",
                table: "WorkoutRecord",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutRecord_UserModel_UserEmail",
                table: "WorkoutRecord",
                column: "UserEmail",
                principalTable: "UserModel",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutRecord_WorkoutType_WorkoutTypeId",
                table: "WorkoutRecord",
                column: "WorkoutTypeId",
                principalTable: "WorkoutType",
                principalColumn: "WorkoutID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutRecord_UserModel_UserEmail",
                table: "WorkoutRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutRecord_WorkoutType_WorkoutTypeId",
                table: "WorkoutRecord");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutRecord_UserEmail",
                table: "WorkoutRecord");

            migrationBuilder.RenameColumn(
                name: "WorkoutTypeId",
                table: "WorkoutRecord",
                newName: "fk_workouttypeid");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutRecord_WorkoutTypeId",
                table: "WorkoutRecord",
                newName: "IX_WorkoutRecord_fk_workouttypeid");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "WorkoutRecord",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutRecord_WorkoutType_fk_workouttypeid",
                table: "WorkoutRecord",
                column: "fk_workouttypeid",
                principalTable: "WorkoutType",
                principalColumn: "WorkoutID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

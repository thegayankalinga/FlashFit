using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    /// <inheritdoc />
    public partial class UdpateCheatmealRecordEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheatmealRecord_CheatmealType_fk_cheatmealtypeid",
                table: "CheatmealRecord");

            migrationBuilder.RenameColumn(
                name: "fk_cheatmealtypeid",
                table: "CheatmealRecord",
                newName: "CheatmealId");

            migrationBuilder.RenameIndex(
                name: "IX_CheatmealRecord_fk_cheatmealtypeid",
                table: "CheatmealRecord",
                newName: "IX_CheatmealRecord_CheatmealId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheatmealRecord_CheatmealType_CheatmealId",
                table: "CheatmealRecord",
                column: "CheatmealId",
                principalTable: "CheatmealType",
                principalColumn: "CheatmealId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheatmealRecord_CheatmealType_CheatmealId",
                table: "CheatmealRecord");

            migrationBuilder.RenameColumn(
                name: "CheatmealId",
                table: "CheatmealRecord",
                newName: "fk_cheatmealtypeid");

            migrationBuilder.RenameIndex(
                name: "IX_CheatmealRecord_CheatmealId",
                table: "CheatmealRecord",
                newName: "IX_CheatmealRecord_fk_cheatmealtypeid");

            migrationBuilder.AddForeignKey(
                name: "FK_CheatmealRecord_CheatmealType_fk_cheatmealtypeid",
                table: "CheatmealRecord",
                column: "fk_cheatmealtypeid",
                principalTable: "CheatmealType",
                principalColumn: "CheatmealId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

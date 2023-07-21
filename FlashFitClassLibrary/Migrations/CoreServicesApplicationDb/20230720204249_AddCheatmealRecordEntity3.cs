using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    /// <inheritdoc />
    public partial class AddCheatmealRecordEntity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheatmealRecord",
                columns: table => new
                {
                    CheatmealRecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_cheatmealtypeid = table.Column<int>(type: "int", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightAtMealRecordTime = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CheatmealAddedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheatmealUpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheatmealRecord", x => x.CheatmealRecordID);
                    table.ForeignKey(
                        name: "FK_CheatmealRecord_CheatmealType_fk_cheatmealtypeid",
                        column: x => x.fk_cheatmealtypeid,
                        principalTable: "CheatmealType",
                        principalColumn: "CheatmealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheatmealRecord_fk_cheatmealtypeid",
                table: "CheatmealRecord",
                column: "fk_cheatmealtypeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheatmealRecord");
        }
    }
}

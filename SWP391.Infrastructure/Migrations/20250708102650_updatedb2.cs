using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService");

            migrationBuilder.DropIndex(
                name: "IX_TestService_TestResultId",
                table: "TestService");

            migrationBuilder.DropIndex(
                name: "IX_AdviseService_AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "TestResultId",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "AdviseService");

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "TestResult",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestServiceId",
                table: "TestResult",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdviseServiceId",
                table: "AdviseNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "AdviseNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TestResult_TestServiceId",
                table: "TestResult",
                column: "TestServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AdviseNote_AdviseServiceId",
                table: "AdviseNote",
                column: "AdviseServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseNote_AdviseService_AdviseServiceId",
                table: "AdviseNote",
                column: "AdviseServiceId",
                principalTable: "AdviseService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResult_TestService_TestServiceId",
                table: "TestResult",
                column: "TestServiceId",
                principalTable: "TestService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseNote_AdviseService_AdviseServiceId",
                table: "AdviseNote");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResult_TestService_TestServiceId",
                table: "TestResult");

            migrationBuilder.DropIndex(
                name: "IX_TestResult_TestServiceId",
                table: "TestResult");

            migrationBuilder.DropIndex(
                name: "IX_AdviseNote_AdviseServiceId",
                table: "AdviseNote");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "TestResult");

            migrationBuilder.DropColumn(
                name: "TestServiceId",
                table: "TestResult");

            migrationBuilder.DropColumn(
                name: "AdviseServiceId",
                table: "AdviseNote");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "AdviseNote");

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "TestService",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestResultId",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdviseNoteId",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TestService_TestResultId",
                table: "TestService",
                column: "TestResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AdviseService_AdviseNoteId",
                table: "AdviseService",
                column: "AdviseNoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService",
                column: "AdviseNoteId",
                principalTable: "AdviseNote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService",
                column: "TestResultId",
                principalTable: "TestResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

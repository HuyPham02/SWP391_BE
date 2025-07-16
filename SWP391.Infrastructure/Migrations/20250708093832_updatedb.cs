using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_Appointment_AppointmentId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService");

            migrationBuilder.DropIndex(
                name: "IX_AdviseService_AppointmentId",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseService");

            migrationBuilder.AlterColumn<int>(
                name: "TestResultId",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "TestResult",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdviseNoteId",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "AdviseNote",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TestResult_AppointmentId",
                table: "TestResult",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdviseNote_AppointmentId",
                table: "AdviseNote",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseNote_Appointment_AppointmentId",
                table: "AdviseNote",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService",
                column: "AdviseNoteId",
                principalTable: "AdviseNote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResult_Appointment_AppointmentId",
                table: "TestResult",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService",
                column: "TestResultId",
                principalTable: "TestResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseNote_Appointment_AppointmentId",
                table: "AdviseNote");

            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResult_Appointment_AppointmentId",
                table: "TestResult");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService");

            migrationBuilder.DropIndex(
                name: "IX_TestResult_AppointmentId",
                table: "TestResult");

            migrationBuilder.DropIndex(
                name: "IX_AdviseNote_AppointmentId",
                table: "AdviseNote");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "TestResult");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "AdviseNote");

            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseNote");

            migrationBuilder.AlterColumn<int>(
                name: "TestResultId",
                table: "TestService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdviseNoteId",
                table: "AdviseService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "AdviseService",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdviseService_AppointmentId",
                table: "AdviseService",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService",
                column: "AdviseNoteId",
                principalTable: "AdviseNote",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_Appointment_AppointmentId",
                table: "AdviseService",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService",
                column: "TestResultId",
                principalTable: "TestResult",
                principalColumn: "Id");
        }
    }
}

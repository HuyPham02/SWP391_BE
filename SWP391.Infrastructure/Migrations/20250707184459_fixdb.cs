using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixdb : Migration
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
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService");

            migrationBuilder.AlterColumn<int>(
                name: "TestResultId",
                table: "TestService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "TestService",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "AdviseService",
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
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_AdviseService_Appointment_AppointmentId",
                table: "AdviseService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService");

            migrationBuilder.DropForeignKey(
                name: "FK_TestService_TestResult_TestResultId",
                table: "TestService");

            migrationBuilder.AlterColumn<int>(
                name: "TestResultId",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdviseNoteId",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_AdviseNote_AdviseNoteId",
                table: "AdviseService",
                column: "AdviseNoteId",
                principalTable: "AdviseNote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseService_Appointment_AppointmentId",
                table: "AdviseService",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService",
                column: "AppointmentId",
                principalTable: "Appointment",
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

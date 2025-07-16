using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService");

            migrationBuilder.DropIndex(
                name: "IX_TestService_AppointmentId",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "TestService");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "TestService",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestService_AppointmentId",
                table: "TestService",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestService_Appointment_AppointmentId",
                table: "TestService",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }
    }
}

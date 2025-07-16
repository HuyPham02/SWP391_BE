using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedbflow1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsulationType",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseNote");

            migrationBuilder.RenameColumn(
                name: "Sugggestion",
                table: "AdviseNote",
                newName: "Suggestion");

            migrationBuilder.AlterColumn<string>(
                name: "TestName",
                table: "TestService",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestService",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "TestService",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "TestService",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "TestService",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "TestService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConsultationType",
                table: "AdviseService",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AdviseService",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "AdviseService",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AdviseService",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsultantId",
                table: "AdviseNote",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdviseNote_ConsultantId",
                table: "AdviseNote",
                column: "ConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdviseNote_User_ConsultantId",
                table: "AdviseNote",
                column: "ConsultantId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdviseNote_User_ConsultantId",
                table: "AdviseNote");

            migrationBuilder.DropIndex(
                name: "IX_AdviseNote_ConsultantId",
                table: "AdviseNote");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "TestService");

            migrationBuilder.DropColumn(
                name: "ConsultationType",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "AdviseService");

            migrationBuilder.DropColumn(
                name: "ConsultantId",
                table: "AdviseNote");

            migrationBuilder.RenameColumn(
                name: "Suggestion",
                table: "AdviseNote",
                newName: "Sugggestion");

            migrationBuilder.AlterColumn<string>(
                name: "TestName",
                table: "TestService",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "ConsulationType",
                table: "AdviseService",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseNote",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

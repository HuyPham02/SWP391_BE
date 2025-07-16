using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateflow1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseService");

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseNote",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "AdviseNote");

            migrationBuilder.AddColumn<int>(
                name: "ContactType",
                table: "AdviseService",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

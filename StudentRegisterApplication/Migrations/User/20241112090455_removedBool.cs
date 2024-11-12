using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegisterApplication.Migrations.User
{
    /// <inheritdoc />
    public partial class removedBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoggedIn",
                table: "SystemUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LoggedIn",
                table: "SystemUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

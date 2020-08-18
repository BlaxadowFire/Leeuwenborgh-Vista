using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistratieApi.Migrations
{
    public partial class ConnectedRegistrationstoUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_User_UserOvNummer",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_UserOvNummer",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "UserOvNummer",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Registration",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_UserId",
                table: "Registration",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_User_UserId",
                table: "Registration",
                column: "UserId",
                principalTable: "User",
                principalColumn: "OvNummer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_User_UserId",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_UserId",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "UserOvNummer",
                table: "Registration",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registration_UserOvNummer",
                table: "Registration",
                column: "UserOvNummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_User_UserOvNummer",
                table: "Registration",
                column: "UserOvNummer",
                principalTable: "User",
                principalColumn: "OvNummer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

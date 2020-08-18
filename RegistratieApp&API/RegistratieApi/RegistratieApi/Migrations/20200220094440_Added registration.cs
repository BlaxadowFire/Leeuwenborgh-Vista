using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistratieApi.Migrations
{
    public partial class Addedregistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDateTime = table.Column<DateTime>(nullable: false),
                    UserOvNummer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.RegistrationId);
                    table.ForeignKey(
                        name: "FK_Registration_User_UserOvNummer",
                        column: x => x.UserOvNummer,
                        principalTable: "User",
                        principalColumn: "OvNummer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registration_UserOvNummer",
                table: "Registration",
                column: "UserOvNummer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registration");
        }
    }
}

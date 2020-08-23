using Microsoft.EntityFrameworkCore.Migrations;

namespace NetflixCasusApi.Migrations
{
    public partial class AddedThingyToSubscriptionBecauseItIsAnnoyingMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Subscription",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Subscription");
        }
    }
}

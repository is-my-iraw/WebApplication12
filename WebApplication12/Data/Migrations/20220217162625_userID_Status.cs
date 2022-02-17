using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Data.Migrations
{
    public partial class userID_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "contacts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class AddedIsVoted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVoted",
                table: "Members",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVoted",
                table: "Members");
        }
    }
}

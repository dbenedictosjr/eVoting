using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class RemovedIsVotedAddedVoted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVoted",
                table: "Members");

            migrationBuilder.AddColumn<bool>(
                name: "Voted",
                table: "Members",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voted",
                table: "Members");

            migrationBuilder.AddColumn<bool>(
                name: "IsVoted",
                table: "Members",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class AddedBulletin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bulletins",
                columns: table => new
                {
                    BulletinId = table.Column<Guid>(nullable: false),
                    DatePosted = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    MemberId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulletins", x => x.BulletinId);
                    table.ForeignKey(
                        name: "FK_Bulletins_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bulletins_MemberId",
                table: "Bulletins",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bulletins");
        }
    }
}

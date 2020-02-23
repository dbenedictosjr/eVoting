using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class AddedVoteEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_CandidateMemberID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_NomineeMemberID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Positions_PositionID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Roles_RoleID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionID",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleID",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Roles_RoleID",
                table: "RoleAccesses");

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteID = table.Column<Guid>(nullable: false),
                    MemberID = table.Column<Guid>(nullable: false),
                    DateVoted = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ElectionID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteID);
                    table.ForeignKey(
                        name: "FK_Votes_Elections_ElectionID",
                        column: x => x.ElectionID,
                        principalTable: "Elections",
                        principalColumn: "ElectionID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Votes_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VoteDetails",
                columns: table => new
                {
                    VoteDetailID = table.Column<Guid>(nullable: false),
                    VoteID = table.Column<Guid>(nullable: false),
                    CandidateID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteDetails", x => x.VoteDetailID);
                    table.ForeignKey(
                        name: "FK_VoteDetails_Candidates_CandidateID",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VoteDetails_Votes_VoteID",
                        column: x => x.VoteID,
                        principalTable: "Votes",
                        principalColumn: "VoteID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoteDetails_CandidateID",
                table: "VoteDetails",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteDetails_VoteID",
                table: "VoteDetails",
                column: "VoteID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectionID",
                table: "Votes",
                column: "ElectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_MemberID",
                table: "Votes",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_CandidateMemberID",
                table: "Candidates",
                column: "CandidateMemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_NomineeMemberID",
                table: "Candidates",
                column: "NomineeMemberID",
                principalTable: "Members",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Positions_PositionID",
                table: "Candidates",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "PositionID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Roles_RoleID",
                table: "Members",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionID",
                table: "Positions",
                column: "ElectionID",
                principalTable: "Elections",
                principalColumn: "ElectionID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleID",
                table: "RoleAccesses",
                column: "ModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Roles_RoleID",
                table: "RoleAccesses",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_CandidateMemberID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_NomineeMemberID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Positions_PositionID",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Roles_RoleID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionID",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleID",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Roles_RoleID",
                table: "RoleAccesses");

            migrationBuilder.DropTable(
                name: "VoteDetails");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_CandidateMemberID",
                table: "Candidates",
                column: "CandidateMemberID",
                principalTable: "Members",
                principalColumn: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_NomineeMemberID",
                table: "Candidates",
                column: "NomineeMemberID",
                principalTable: "Members",
                principalColumn: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Positions_PositionID",
                table: "Candidates",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Roles_RoleID",
                table: "Members",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionID",
                table: "Positions",
                column: "ElectionID",
                principalTable: "Elections",
                principalColumn: "ElectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleID",
                table: "RoleAccesses",
                column: "ModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Roles_RoleID",
                table: "RoleAccesses",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID");
        }
    }
}

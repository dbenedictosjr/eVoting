using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class AddedInventoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_CandidateMemberId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_NomineeMemberId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Roles_RoleId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleId",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Roles_RoleId",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteDetails_Candidates_CandidateId",
                table: "VoteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteDetails_Votes_VoteId",
                table: "VoteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Elections_ElectionId",
                table: "Votes");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_CandidateMemberId",
                table: "Candidates",
                column: "CandidateMemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_NomineeMemberId",
                table: "Candidates",
                column: "NomineeMemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Roles_RoleId",
                table: "Members",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "ElectionId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleId",
                table: "RoleAccesses",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Roles_RoleId",
                table: "RoleAccesses",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteDetails_Candidates_CandidateId",
                table: "VoteDetails",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "CandidateId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteDetails_Votes_VoteId",
                table: "VoteDetails",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "VoteId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Elections_ElectionId",
                table: "Votes",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "ElectionId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_CandidateMemberId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Members_NomineeMemberId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Roles_RoleId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleId",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAccesses_Roles_RoleId",
                table: "RoleAccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteDetails_Candidates_CandidateId",
                table: "VoteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteDetails_Votes_VoteId",
                table: "VoteDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Elections_ElectionId",
                table: "Votes");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_CandidateMemberId",
                table: "Candidates",
                column: "CandidateMemberId",
                principalTable: "Members",
                principalColumn: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Members_NomineeMemberId",
                table: "Candidates",
                column: "NomineeMemberId",
                principalTable: "Members",
                principalColumn: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Positions_PositionId",
                table: "Candidates",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Roles_RoleId",
                table: "Members",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Elections_ElectionId",
                table: "Positions",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "ElectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Modules_ModuleId",
                table: "RoleAccesses",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAccesses_Roles_RoleId",
                table: "RoleAccesses",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VoteDetails_Candidates_CandidateId",
                table: "VoteDetails",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_VoteDetails_Votes_VoteId",
                table: "VoteDetails",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Elections_ElectionId",
                table: "Votes",
                column: "ElectionId",
                principalTable: "Elections",
                principalColumn: "ElectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Members_MemberId",
                table: "Votes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId");
        }
    }
}

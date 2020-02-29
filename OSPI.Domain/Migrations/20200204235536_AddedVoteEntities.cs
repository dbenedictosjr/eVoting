﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class AddedVoteEntities : Migration
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

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteId = table.Column<Guid>(nullable: false),
                    MemberId = table.Column<Guid>(nullable: false),
                    DateVoted = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ElectionId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteId);
                    table.ForeignKey(
                        name: "FK_Votes_Elections_ElectionId",
                        column: x => x.ElectionId,
                        principalTable: "Elections",
                        principalColumn: "ElectionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Votes_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VoteDetails",
                columns: table => new
                {
                    VoteDetailId = table.Column<Guid>(nullable: false),
                    VoteId = table.Column<Guid>(nullable: false),
                    CandidateId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteDetails", x => x.VoteDetailId);
                    table.ForeignKey(
                        name: "FK_VoteDetails_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_VoteDetails_Votes_VoteId",
                        column: x => x.VoteId,
                        principalTable: "Votes",
                        principalColumn: "VoteId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoteDetails_CandidateId",
                table: "VoteDetails",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteDetails_VoteId",
                table: "VoteDetails",
                column: "VoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectionId",
                table: "Votes",
                column: "ElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_MemberId",
                table: "Votes",
                column: "MemberId");

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

            migrationBuilder.DropTable(
                name: "VoteDetails");

            migrationBuilder.DropTable(
                name: "Votes");

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
        }
    }
}

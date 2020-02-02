using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class InitialVotingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleID = table.Column<Guid>(nullable: false),
                    ModuleName = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    RequiredCandidates = table.Column<int>(type: "INT", nullable: false),
                    Qualifications = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Ballots",
                columns: table => new
                {
                    BallotID = table.Column<Guid>(nullable: false),
                    RegStartDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RegEndDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    VoteStartDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    VoteEndDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    PositionID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballots", x => x.BallotID);
                    table.ForeignKey(
                        name: "FK_Ballots_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<Guid>(nullable: false),
                    MemberNo = table.Column<string>(type: "CHAR(8)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    FirstName = table.Column<string>(type: "CHAR(30)", nullable: true),
                    MiddleName = table.Column<string>(type: "CHAR(30)", nullable: true),
                    LastName = table.Column<string>(type: "CHAR(30)", nullable: true),
                    HomeAddress = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    EmailAddress = table.Column<string>(type: "CHAR(50)", nullable: true),
                    PhoneNo = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    MobileNo = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Capital = table.Column<double>(type: "FLOAT", nullable: false),
                    MemberStatus = table.Column<string>(type: "CHAR(30)", nullable: true),
                    CreditStatus = table.Column<string>(type: "CHAR(30)", nullable: true),
                    Password = table.Column<string>(type: "CHAR(20)", nullable: true),
                    DateHired = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Salary = table.Column<double>(type: "FLOAT", nullable: false),
                    AccountNo = table.Column<string>(type: "CHAR(30)", nullable: true),
                    RoleID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Members_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RoleAccesses",
                columns: table => new
                {
                    RoleAccessID = table.Column<Guid>(nullable: false),
                    RoleID = table.Column<Guid>(nullable: false),
                    ModuleID = table.Column<Guid>(nullable: false),
                    CanAdd = table.Column<bool>(nullable: false),
                    CanEdit = table.Column<bool>(nullable: false),
                    CanDelete = table.Column<bool>(nullable: false),
                    CanView = table.Column<bool>(nullable: false),
                    CanPrint = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAccesses", x => x.RoleAccessID);
                    table.ForeignKey(
                        name: "FK_RoleAccesses_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RoleAccesses_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateID = table.Column<Guid>(nullable: false),
                    CandidateMemberID = table.Column<Guid>(nullable: false),
                    BallotID = table.Column<Guid>(nullable: false),
                    NomineeMemberID = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(type: "char(30)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateID);
                    table.ForeignKey(
                        name: "FK_Candidates_Ballots_BallotID",
                        column: x => x.BallotID,
                        principalTable: "Ballots",
                        principalColumn: "BallotID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Candidates_Members_CandidateMemberID",
                        column: x => x.CandidateMemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Candidates_Members_NomineeMemberID",
                        column: x => x.NomineeMemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Votes", x => x.VoteID);
                    table.ForeignKey(
                        name: "FK_Votes_Candidates_CandidateID",
                        column: x => x.CandidateID,
                        principalTable: "Candidates",
                        principalColumn: "CandidateID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ResulID = table.Column<Guid>(nullable: false),
                    VoteID = table.Column<Guid>(nullable: false),
                    MemberID = table.Column<Guid>(nullable: false),
                    DateVoted = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ResulID);
                    table.ForeignKey(
                        name: "FK_Results_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Results_Votes_VoteID",
                        column: x => x.VoteID,
                        principalTable: "Votes",
                        principalColumn: "VoteID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ballots_PositionID",
                table: "Ballots",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_BallotID",
                table: "Candidates",
                column: "BallotID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CandidateMemberID",
                table: "Candidates",
                column: "CandidateMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_NomineeMemberID",
                table: "Candidates",
                column: "NomineeMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RoleID",
                table: "Members",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_MemberID",
                table: "Results",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_VoteID",
                table: "Results",
                column: "VoteID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_ModuleID",
                table: "RoleAccesses",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_RoleID",
                table: "RoleAccesses",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_CandidateID",
                table: "Votes",
                column: "CandidateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "RoleAccesses");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Ballots");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

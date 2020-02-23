using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSPI.Domain.Migrations
{
    public partial class InitialDBEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    ElectionID = table.Column<Guid>(nullable: false),
                    RefCode = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    RegStartDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RegEndDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    VotingStartDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    VotingEndDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.ElectionID);
                });

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
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<Guid>(nullable: false),
                    PositionName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    RequiredCandidates = table.Column<int>(type: "INT", nullable: false),
                    Qualifications = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    ElectionID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                    table.ForeignKey(
                        name: "FK_Positions_Elections_ElectionID",
                        column: x => x.ElectionID,
                        principalTable: "Elections",
                        principalColumn: "ElectionID",
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
                    PositionID = table.Column<Guid>(nullable: false),
                    CandidateMemberID = table.Column<Guid>(nullable: false),
                    NomineeMemberID = table.Column<Guid>(nullable: false),
                    Plataforma = table.Column<string>(type: "varchar(1000)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Candidates_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CandidateMemberID",
                table: "Candidates",
                column: "CandidateMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_NomineeMemberID",
                table: "Candidates",
                column: "NomineeMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_PositionID",
                table: "Candidates",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_RoleID",
                table: "Members",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_ElectionID",
                table: "Positions",
                column: "ElectionID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_ModuleID",
                table: "RoleAccesses",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccesses_RoleID",
                table: "RoleAccesses",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "RoleAccesses");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Elections");
        }
    }
}

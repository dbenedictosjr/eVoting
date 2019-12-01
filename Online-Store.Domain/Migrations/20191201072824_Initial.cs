using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Store.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category1s",
                columns: table => new
                {
                    Cat1ID = table.Column<Guid>(nullable: false),
                    Cat1Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cat1Desc = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cat1Img = table.Column<string>(type: "varchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category1s", x => x.Cat1ID);
                });

            migrationBuilder.CreateTable(
                name: "UOMs",
                columns: table => new
                {
                    UOMID = table.Column<Guid>(nullable: false),
                    UOMCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    UOMDesc = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOMs", x => x.UOMID);
                });

            migrationBuilder.CreateTable(
                name: "Category2s",
                columns: table => new
                {
                    Cat2ID = table.Column<Guid>(nullable: false),
                    Cat2Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cat2Desc = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cat2Img = table.Column<string>(type: "varchar(max)", nullable: true),
                    Cat1ID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Category1Cat1ID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category2s", x => x.Cat2ID);
                    table.ForeignKey(
                        name: "FK_Category2s_Category1s_Category1Cat1ID",
                        column: x => x.Category1Cat1ID,
                        principalTable: "Category1s",
                        principalColumn: "Cat1ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category3s",
                columns: table => new
                {
                    Cat3ID = table.Column<Guid>(nullable: false),
                    Cat3Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cat3Desc = table.Column<string>(type: "varchar(50)", nullable: true),
                    Cat3Img = table.Column<string>(type: "varchar(max)", nullable: true),
                    Cat2ID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Category2Cat2ID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category3s", x => x.Cat3ID);
                    table.ForeignKey(
                        name: "FK_Category3s_Category2s_Category2Cat2ID",
                        column: x => x.Category2Cat2ID,
                        principalTable: "Category2s",
                        principalColumn: "Cat2ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProdID = table.Column<Guid>(nullable: false),
                    ProdCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    ShortDesc = table.Column<string>(type: "varchar(40)", nullable: true),
                    LongDesc = table.Column<string>(type: "varchar(100)", nullable: true),
                    Cat3ID = table.Column<Guid>(nullable: false),
                    UOMID = table.Column<long>(nullable: false),
                    UnitQty = table.Column<double>(nullable: false),
                    Mintock = table.Column<double>(nullable: false),
                    MaxStock = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    MarkupAmount = table.Column<double>(nullable: false),
                    MarkupPercent = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Vatable = table.Column<bool>(nullable: true),
                    Barcode = table.Column<string>(type: "varchar(20)", nullable: true),
                    Stock = table.Column<double>(nullable: false),
                    Active = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Category3Cat3ID = table.Column<Guid>(nullable: true),
                    OUMUOMID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProdID);
                    table.ForeignKey(
                        name: "FK_Products_Category3s_Category3Cat3ID",
                        column: x => x.Category3Cat3ID,
                        principalTable: "Category3s",
                        principalColumn: "Cat3ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_UOMs_OUMUOMID",
                        column: x => x.OUMUOMID,
                        principalTable: "UOMs",
                        principalColumn: "UOMID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category2s_Category1Cat1ID",
                table: "Category2s",
                column: "Category1Cat1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Category3s_Category2Cat2ID",
                table: "Category3s",
                column: "Category2Cat2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category3Cat3ID",
                table: "Products",
                column: "Category3Cat3ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OUMUOMID",
                table: "Products",
                column: "OUMUOMID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category3s");

            migrationBuilder.DropTable(
                name: "UOMs");

            migrationBuilder.DropTable(
                name: "Category2s");

            migrationBuilder.DropTable(
                name: "Category1s");
        }
    }
}

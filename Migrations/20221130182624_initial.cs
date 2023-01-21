using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InversiApp.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquityInvestments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dividends = table.Column<double>(type: "float", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    Nominals = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    investmentType = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false),
                    ArsUsdRate = table.Column<double>(type: "float", nullable: false),
                    BuyPriceUsd = table.Column<double>(type: "float", nullable: false),
                    BuyPriceArs = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquityInvestments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FixedInvestments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    Nominals = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    investmentType = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false),
                    ArsUsdRate = table.Column<double>(type: "float", nullable: false),
                    BuyPriceUsd = table.Column<double>(type: "float", nullable: false),
                    BuyPriceArs = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedInvestments", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquityInvestments");

            migrationBuilder.DropTable(
                name: "FixedInvestments");
        }
    }
}

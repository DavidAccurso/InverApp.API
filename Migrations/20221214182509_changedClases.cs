using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InversiApp.API.Migrations
{
    /// <inheritdoc />
    public partial class changedClases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquityInvestments");

            migrationBuilder.DropTable(
                name: "FixedInvestments");

            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    Nominals = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    investmentType = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false),
                    ArsUsdRate = table.Column<double>(type: "float", nullable: false),
                    BuyPriceUsd = table.Column<double>(type: "float", nullable: false),
                    BuyPriceArs = table.Column<double>(type: "float", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    Dividends = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investments");

            migrationBuilder.CreateTable(
                name: "EquityInvestments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArsUsdRate = table.Column<double>(type: "float", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyPriceArs = table.Column<double>(type: "float", nullable: false),
                    BuyPriceUsd = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dividends = table.Column<double>(type: "float", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false),
                    Nominals = table.Column<double>(type: "float", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    investmentType = table.Column<int>(type: "int", nullable: false)
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
                    ArsUsdRate = table.Column<double>(type: "float", nullable: false),
                    Asset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyPriceArs = table.Column<double>(type: "float", nullable: false),
                    BuyPriceUsd = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<double>(type: "float", nullable: false),
                    Nominals = table.Column<double>(type: "float", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    investmentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedInvestments", x => x.ID);
                });
        }
    }
}

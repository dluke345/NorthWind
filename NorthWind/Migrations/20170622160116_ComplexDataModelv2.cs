using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthWind.Migrations
{
    public partial class ComplexDataModelv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEmployeeTerritory",
                table: "tblEmployeeTerritory");

            migrationBuilder.DropIndex(
                name: "IX_tblEmployeeTerritory_EmployeeID",
                table: "tblEmployeeTerritory");

            migrationBuilder.DropColumn(
                name: "EmployeeTerritoryID",
                table: "tblEmployeeTerritory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEmployeeTerritory",
                table: "tblEmployeeTerritory",
                columns: new[] { "EmployeeID", "TerritoryID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEmployeeTerritory",
                table: "tblEmployeeTerritory");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeTerritoryID",
                table: "tblEmployeeTerritory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEmployeeTerritory",
                table: "tblEmployeeTerritory",
                column: "EmployeeTerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeTerritory_EmployeeID",
                table: "tblEmployeeTerritory",
                column: "EmployeeID");
        }
    }
}

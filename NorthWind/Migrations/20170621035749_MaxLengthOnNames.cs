using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthWind.Migrations
{
    public partial class MaxLengthOnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProduct_tblCustomer_CustomerId",
                table: "tblProduct");

            migrationBuilder.DropIndex(
                name: "IX_tblProduct_CustomerId",
                table: "tblProduct");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "tblProduct");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "tblCustomer",
                newName: "CustomerID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tblEmployee",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tblEmployee",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "tblEmployee",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID1",
                table: "tblEmployee",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "tblCustomer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateTable(
                name: "tblCustomerDemographic",
                columns: table => new
                {
                    CustomerDemographicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomerDemographic", x => x.CustomerDemographicID);
                });

            migrationBuilder.CreateTable(
                name: "tblRegion",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRegion", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "tblShipper",
                columns: table => new
                {
                    ShipperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblShipper", x => x.ShipperID);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomerCustomerDemo",
                columns: table => new
                {
                    CustomerCustomerDemoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerDemographicID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomerCustomerDemo", x => x.CustomerCustomerDemoID);
                    table.ForeignKey(
                        name: "FK_tblCustomerCustomerDemo_tblCustomerDemographic_CustomerDemographicID",
                        column: x => x.CustomerDemographicID,
                        principalTable: "tblCustomerDemographic",
                        principalColumn: "CustomerDemographicID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCustomerCustomerDemo_tblCustomer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblTerritory",
                columns: table => new
                {
                    TerritoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegionID = table.Column<int>(nullable: false),
                    TerritoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTerritory", x => x.TerritoryID);
                    table.ForeignKey(
                        name: "FK_tblTerritory_tblRegion_RegionID",
                        column: x => x.RegionID,
                        principalTable: "tblRegion",
                        principalColumn: "RegionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrder",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Freight = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    ShipAddress = table.Column<string>(nullable: true),
                    ShipCity = table.Column<string>(nullable: true),
                    ShipCountry = table.Column<string>(nullable: true),
                    ShipName = table.Column<string>(nullable: true),
                    ShipPostalCode = table.Column<string>(nullable: true),
                    ShipRegion = table.Column<string>(nullable: true),
                    ShipVia = table.Column<int>(nullable: false),
                    ShippedDate = table.Column<DateTime>(nullable: false),
                    ShipperID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrder", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblCustomer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "tblCustomer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblEmployee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "tblEmployee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrder_tblShipper_ShipperID",
                        column: x => x.ShipperID,
                        principalTable: "tblShipper",
                        principalColumn: "ShipperID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployeeTerritory",
                columns: table => new
                {
                    EmployeeTerritoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: false),
                    TerritoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployeeTerritory", x => x.EmployeeTerritoryID);
                    table.ForeignKey(
                        name: "FK_tblEmployeeTerritory_tblEmployee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "tblEmployee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEmployeeTerritory_tblTerritory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "tblTerritory",
                        principalColumn: "TerritoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrderDetail",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discount = table.Column<double>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderDetail", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_tblOrderDetail_tblOrder_OrderID",
                        column: x => x.OrderID,
                        principalTable: "tblOrder",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrderDetail_tblProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tblProduct",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployee_EmployeeID1",
                table: "tblEmployee",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerCustomerDemo_CustomerDemographicID",
                table: "tblCustomerCustomerDemo",
                column: "CustomerDemographicID");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerCustomerDemo_CustomerID",
                table: "tblCustomerCustomerDemo",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeTerritory_EmployeeID",
                table: "tblEmployeeTerritory",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeTerritory_TerritoryID",
                table: "tblEmployeeTerritory",
                column: "TerritoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CustomerID",
                table: "tblOrder",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_EmployeeID",
                table: "tblOrder",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_ShipperID",
                table: "tblOrder",
                column: "ShipperID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetail_OrderID",
                table: "tblOrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetail_ProductID",
                table: "tblOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblTerritory_RegionID",
                table: "tblTerritory",
                column: "RegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_tblEmployee_tblEmployee_EmployeeID1",
                table: "tblEmployee",
                column: "EmployeeID1",
                principalTable: "tblEmployee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblEmployee_tblEmployee_EmployeeID1",
                table: "tblEmployee");

            migrationBuilder.DropTable(
                name: "tblCustomerCustomerDemo");

            migrationBuilder.DropTable(
                name: "tblEmployeeTerritory");

            migrationBuilder.DropTable(
                name: "tblOrderDetail");

            migrationBuilder.DropTable(
                name: "tblCustomerDemographic");

            migrationBuilder.DropTable(
                name: "tblTerritory");

            migrationBuilder.DropTable(
                name: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblRegion");

            migrationBuilder.DropTable(
                name: "tblShipper");

            migrationBuilder.DropIndex(
                name: "IX_tblEmployee_EmployeeID1",
                table: "tblEmployee");

            migrationBuilder.DropColumn(
                name: "EmployeeID1",
                table: "tblEmployee");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "tblCustomer",
                newName: "CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "tblProduct",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tblEmployee",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "tblEmployee",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "tblEmployee",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "tblCustomer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_CustomerId",
                table: "tblProduct",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblCustomer_CustomerId",
                table: "tblProduct",
                column: "CustomerId",
                principalTable: "tblCustomer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NorthWind.Data;

namespace NorthWind.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20170621201805_ComplexDataModel")]
    partial class ComplexDataModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NorthWind.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("Picture");

                    b.HasKey("CategoryID");

                    b.ToTable("tblCategory");
                });

            modelBuilder.Entity("NorthWind.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country")
                        .HasMaxLength(25);

                    b.Property<string>("Phone")
                        .HasMaxLength(14);

                    b.Property<int>("PostalCode");

                    b.HasKey("CustomerID");

                    b.ToTable("tblCustomer");
                });

            modelBuilder.Entity("NorthWind.Models.CustomerCustomerDemo", b =>
                {
                    b.Property<int>("CustomerDemographicID");

                    b.Property<int>("CustomerID");

                    b.HasKey("CustomerDemographicID", "CustomerID");

                    b.HasIndex("CustomerID");

                    b.ToTable("tblCustomerCustomerDemo");
                });

            modelBuilder.Entity("NorthWind.Models.CustomerDemographic", b =>
                {
                    b.Property<int>("CustomerDemographicID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerDesc");

                    b.HasKey("CustomerDemographicID");

                    b.ToTable("tblCustomerDemographic");
                });

            modelBuilder.Entity("NorthWind.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentDesc");

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.HasKey("DepartmentID");

                    b.ToTable("tblDepartment");
                });

            modelBuilder.Entity("NorthWind.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("DOB");

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Email");

                    b.Property<int?>("EmployeeID1");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("EmployeeID1");

                    b.ToTable("tblEmployee");
                });

            modelBuilder.Entity("NorthWind.Models.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeTerritoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeID");

                    b.Property<int>("TerritoryID");

                    b.HasKey("EmployeeTerritoryID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("tblEmployeeTerritory");
                });

            modelBuilder.Entity("NorthWind.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerID");

                    b.Property<int>("EmployeeID");

                    b.Property<double>("Freight");

                    b.Property<DateTime>("OrderDate");

                    b.Property<DateTime>("RequiredDate");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipCity");

                    b.Property<string>("ShipCountry");

                    b.Property<string>("ShipName");

                    b.Property<string>("ShipPostalCode");

                    b.Property<string>("ShipRegion");

                    b.Property<int>("ShipVia");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<int?>("ShipperID");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShipperID");

                    b.ToTable("tblOrder");
                });

            modelBuilder.Entity("NorthWind.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Discount");

                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("tblOrderDetail");
                });

            modelBuilder.Entity("NorthWind.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ReorderLevel");

                    b.Property<int>("SupplierID");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<int>("UnitsInStock");

                    b.Property<int>("UnitsOnOrder");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("NorthWind.Models.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RegionID");

                    b.ToTable("tblRegion");
                });

            modelBuilder.Entity("NorthWind.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.HasKey("ShipperID");

                    b.ToTable("tblShipper");
                });

            modelBuilder.Entity("NorthWind.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("ContactName")
                        .IsRequired();

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("Fax");

                    b.Property<string>("HomePage");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Region");

                    b.HasKey("SupplierID");

                    b.ToTable("tblSupplier");
                });

            modelBuilder.Entity("NorthWind.Models.Territory", b =>
                {
                    b.Property<int>("TerritoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RegionID");

                    b.Property<string>("TerritoryName")
                        .IsRequired();

                    b.HasKey("TerritoryID");

                    b.HasIndex("RegionID");

                    b.ToTable("tblTerritory");
                });

            modelBuilder.Entity("NorthWind.Models.CustomerCustomerDemo", b =>
                {
                    b.HasOne("NorthWind.Models.CustomerDemographic", "CustomerDemographic")
                        .WithMany("CustomerCustomerDemos")
                        .HasForeignKey("CustomerDemographicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Customer", "Customer")
                        .WithMany("CustomerCustomerDemos")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NorthWind.Models.Employee", b =>
                {
                    b.HasOne("NorthWind.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Employee")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeID1");
                });

            modelBuilder.Entity("NorthWind.Models.EmployeeTerritory", b =>
                {
                    b.HasOne("NorthWind.Models.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NorthWind.Models.Order", b =>
                {
                    b.HasOne("NorthWind.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperID");
                });

            modelBuilder.Entity("NorthWind.Models.OrderDetail", b =>
                {
                    b.HasOne("NorthWind.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NorthWind.Models.Product", b =>
                {
                    b.HasOne("NorthWind.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NorthWind.Models.Territory", b =>
                {
                    b.HasOne("NorthWind.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NorthWind.Data;

namespace NorthWind.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20170613192203_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.Property<string>("Picture");

                    b.HasKey("CategoryID");

                    b.ToTable("tblCategory");
                });

            modelBuilder.Entity("NorthWind.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("Phone");

                    b.Property<int>("PostalCode");

                    b.HasKey("CustomerId");

                    b.ToTable("tblCustomer");
                });

            modelBuilder.Entity("NorthWind.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentDesc");

                    b.Property<string>("DepartmentName");

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

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Title");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("tblEmployee");
                });

            modelBuilder.Entity("NorthWind.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Description");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("Name");

                    b.Property<int>("ReorderLevel");

                    b.Property<int>("SupplierID");

                    b.Property<double>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.Property<int>("UnitsOnOrder");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SupplierID");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("NorthWind.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

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

            modelBuilder.Entity("NorthWind.Models.Employee", b =>
                {
                    b.HasOne("NorthWind.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NorthWind.Models.Product", b =>
                {
                    b.HasOne("NorthWind.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NorthWind.Models.Customer")
                        .WithMany("Product")
                        .HasForeignKey("CustomerId");

                    b.HasOne("NorthWind.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

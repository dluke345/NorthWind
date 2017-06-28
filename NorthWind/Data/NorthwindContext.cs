using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthWind.Models;

namespace NorthWind.Data
{

    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
      
        public DbSet<Department> Departments { get; set; }      
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("tblDepartment");         
            modelBuilder.Entity<Supplier>().ToTable("tblSupplier");
            modelBuilder.Entity<Category>().ToTable("tblCategory");
            modelBuilder.Entity<Customer>().ToTable("tblCustomer");
            modelBuilder.Entity<Product>().ToTable("tblProduct");
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            modelBuilder.Entity<Region>().ToTable("tblRegion");
            modelBuilder.Entity<Territory>().ToTable("tblTerritory");
            modelBuilder.Entity<EmployeeTerritory>().ToTable("tblEmployeeTerritory");

            modelBuilder.Entity<EmployeeTerritory>()
                .HasKey(e => new { e.EmployeeID, e.TerritoryID });

            modelBuilder.Entity<Shipper>().ToTable("tblShipper");
            modelBuilder.Entity<CustomerDemographic>().ToTable("tblCustomerDemographic");
            modelBuilder.Entity<CustomerCustomerDemo>().ToTable("tblCustomerCustomerDemo");

            modelBuilder.Entity<CustomerCustomerDemo>()
                .HasKey(c => new { c.CustomerDemographicID, c.CustomerID });

            modelBuilder.Entity<Order>().ToTable("tblOrder");
            modelBuilder.Entity<OrderDetail>().ToTable("tblOrderDetail");
        }
        
    }
}

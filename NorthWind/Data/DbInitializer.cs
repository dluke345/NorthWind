using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthWind.Models;

namespace NorthWind.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NorthwindContext context)
        {
            context.Database.EnsureCreated();
            if (context.Departments.Any())
            {
                return;
            }

            var departments = new Department[]
            {
                new Department{DepartmentName="Development", DepartmentDesc="Develops things" },
                new Department{DepartmentName="Support", DepartmentDesc="Support things" },
                new Department{DepartmentName="Product", DepartmentDesc="Product things" }
            };
            foreach(Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();


            var employees = new Employee[]
            {
                new Employee{DepartmentID=1, FirstName="David", LastName="Luke", DOB=DateTime.Parse("06/26/1988"), PhoneNumber="913-530-7460", Email="dluke345@gmail.com", Bio="Empty", Title="Coder", HireDate=DateTime.Parse("01/01/2013") },
                new Employee{DepartmentID=2, FirstName="Omar", LastName="DiaDia", DOB=DateTime.Parse("09/12/1992"), PhoneNumber="913-678-4356", Email="testy@gmail.com", Bio="Empty", Title="Coder", HireDate=DateTime.Parse("02/05/2012") },
                new Employee{DepartmentID=1, FirstName="Bob", LastName="Sagot", DOB=DateTime.Parse("09/12/1992"), PhoneNumber="913-678-4356", Email="poopy@gmail.com", Bio="Empty", Title="Nothing", HireDate=DateTime.Parse("02/05/2012") }

            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();


            var suppliers = new Supplier[]
            {
                new Supplier{ContactName="Jimmy Jackson", CompanyName="Cerner", ContactTitle="Account Rep", Phone="923-534-7855"},
                new Supplier{ContactName="Darnel Poop", CompanyName="MedTrak", ContactTitle="Account Rep", Phone="923-534-7855"},
                new Supplier{ContactName="Lexis Advance", CompanyName="eSolutions", ContactTitle="Account Rep", Phone="923-534-7855"}
            };
            foreach (Supplier s in suppliers)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();


            var categories = new Category[]
            {
                new Category{CategoryName="Hardware", Description="Parts for Computer", Picture="something.jpg"},
                new Category{CategoryName="Pictures", Description="Pics", Picture="something.jpg"},
                new Category{CategoryName="Beverages", Description="Soft drinks, coffees, teas, beers and ales", Picture="something.jpg"},
                new Category{CategoryName="Condiments", Description="Sweet and savory sauces, relishes, spreads and blah", Picture="something.jpg"},
                new Category{CategoryName="Software", Description="Applications and stuff", Picture="something.jpg"}
            };
            foreach (Category ca in categories)
            {
                context.Categories.Add(ca);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{CategoryID=1, SupplierID=1, Name="Ram", Description="Memory Stick", UnitPrice=50, UnitsInStock=34, UnitsOnOrder=12, ReorderLevel=10, Discontinued=false },
                new Product{CategoryID=2, SupplierID=2, Name="Ford", Description="Memory Stick", UnitPrice=50, UnitsInStock=34, UnitsOnOrder=12, ReorderLevel=10, Discontinued=false },
                new Product{CategoryID=1, SupplierID=2, Name="Jeep", Description="Memory Stick", UnitPrice=50, UnitsInStock=34, UnitsOnOrder=12, ReorderLevel=10, Discontinued=false }
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer{CompanyName="Best Buy", ContactName="Joe Smith", ContactTitle="Product Manager", Address="8572 W 108th St.", City="Lenexa", Country="USA", PostalCode=66215, Phone="913-123-4567"},
                new Customer{CompanyName="Mirco Center", ContactName="Patrick Skip", ContactTitle="Product Manager", Address="8572 W 108th St.", City="Lenexa", Country="USA", PostalCode=66215, Phone="913-123-4567"},
                new Customer{CompanyName="Newegg", ContactName="Tim Horn", ContactTitle="Product Manager", Address="8572 W 108th St.", City="Lenexa", Country="USA", PostalCode=66215, Phone="913-123-4567"}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();


            var regions = new Region[]
            {
                new Region{ RegionName="Eastern"},
                new Region{ RegionName="Western"},
                new Region{ RegionName="Northern"},
                new Region{ RegionName="Southern"}
            };
            foreach(Region r in regions)
            {
                context.Regions.Add(r);
            }
            context.SaveChanges();

            var territories = new Territory[]
            {
                new Territory{TerritoryName="Westboro", RegionID=1 },
                new Territory{TerritoryName="Bedford", RegionID=2 },
                new Territory{TerritoryName="GeorgeTown", RegionID=3 }
            };
            foreach (Territory t in territories)
            {
                context.Territories.Add(t);
            }
            context.SaveChanges();

            var employeeTerritories = new EmployeeTerritory[]
            {
                new EmployeeTerritory{ EmployeeID=1, TerritoryID=1 },
                new EmployeeTerritory{ EmployeeID=2, TerritoryID=2 },
                new EmployeeTerritory{ EmployeeID=3, TerritoryID=2 }
            };
            foreach (EmployeeTerritory et in employeeTerritories)
            {
                context.EmployeeTerritories.Add(et);
            }
            context.SaveChanges();

            var shippers = new Shipper[]
            {
                new Shipper{ CompanyName="Speedy Express", Phone="(503) 555-9831" },
                new Shipper{ CompanyName="United Package", Phone="(503) 555-3199" },
                new Shipper{ CompanyName="Federal Shipping", Phone="(503) 555-9931" }
            };
            foreach(Shipper sh in shippers)
            {
                context.Shippers.Add(sh);
            }
            context.SaveChanges();


            var customerDemographics = new CustomerDemographic[]
            {
                new CustomerDemographic{ CustomerDesc="blah"},
                new CustomerDemographic{ CustomerDesc="Gucci"},
                new CustomerDemographic{ CustomerDesc="Pucci"}
            };
            foreach(CustomerDemographic cd in customerDemographics)
            {
                context.CustomerDemographics.Add(cd);
            }
            context.SaveChanges();

            var customerCustomerDemos = new CustomerCustomerDemo[]
            {
                new CustomerCustomerDemo{ CustomerDemographicID=1, CustomerID=1 },
                new CustomerCustomerDemo{ CustomerDemographicID=2, CustomerID=2 },
                new CustomerCustomerDemo{ CustomerDemographicID=3, CustomerID=3 }
            };
            foreach (CustomerCustomerDemo ccd in customerCustomerDemos)
            {
                context.CustomerCustomerDemos.Add(ccd);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{CustomerID=1, EmployeeID=1, OrderDate=DateTime.Parse("02/20/2017"), RequiredDate=DateTime.Parse("03/21/2017"), ShippedDate=DateTime.Parse("03/02/2017"), ShipVia=1, ShipName="UPS" },
                new Order{CustomerID=2, EmployeeID=2, OrderDate=DateTime.Parse("02/20/2017"), RequiredDate=DateTime.Parse("03/21/2017"), ShippedDate=DateTime.Parse("03/02/2017"), ShipVia=1, ShipName="UPS" },
                new Order{CustomerID=3, EmployeeID=3, OrderDate=DateTime.Parse("02/20/2017"), RequiredDate=DateTime.Parse("03/21/2017"), ShippedDate=DateTime.Parse("03/02/2017"), ShipVia=1, ShipName="UPS" }
            };
            foreach(Order o in orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();


            var orderDetails = new OrderDetail[]
            {
                new OrderDetail{ OrderID=1, ProductID=1, UnitPrice=65, Quantity=3, Discount=0 },
                new OrderDetail{ OrderID=2, ProductID=1, UnitPrice=88, Quantity=5, Discount=0 },
                new OrderDetail{ OrderID=3, ProductID=1, UnitPrice=155, Quantity=10, Discount=.10 }
            };
            foreach(OrderDetail od in orderDetails)
            {
                context.OrderDetails.Add(od);
            }
            context.SaveChanges();

        }
    }
}

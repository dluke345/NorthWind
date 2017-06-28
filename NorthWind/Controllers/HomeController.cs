using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthWind.Data;
using NorthWind.Models.NorthWIndViewModels;

namespace NorthWind.Controllers
{
    public class HomeController : Controller
    {
        //get instance of the context from ASP.Net Core DI
        private readonly NorthwindContext _context;

        public HomeController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            IQueryable<EmployeeDepartmentGroup> data =
                from employee in _context.Employees
                group employee by employee.Department.DepartmentName into departmentGroup
                select new EmployeeDepartmentGroup()
                {
                    Department = departmentGroup.Key,
                    EmployeeCount = departmentGroup.Count()
                };

            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

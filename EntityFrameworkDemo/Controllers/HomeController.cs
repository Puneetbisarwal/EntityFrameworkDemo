using System.Diagnostics;
using EntityFrameworkDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Employee employee = new Employee();
            employee.Employeename = "Akash Singh";
            employee.Createdon = DateTime.Now;
            employee.Createdby = "Admin";
            employee.Status = "Active";

            EmployeeDbContext db = new EmployeeDbContext();
            db.Employees.Add(employee);
            db.SaveChanges();


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

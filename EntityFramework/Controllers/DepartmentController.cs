using EntityFramework.Data;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();

            return View(departments);
        }

        public IActionResult Employees(int id)
        {
            var employees = _context.Employees
                .Where(e => e.DepartmentId == id)
                .ToList();

            return View(employees);
        }
    }
}
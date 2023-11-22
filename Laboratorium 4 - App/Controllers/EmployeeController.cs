using Microsoft.AspNetCore.Mvc;
using Laboratorium_4___App.Models;

namespace Laboratorium_4___App.Controllers
{
    public class EmployeeController : Controller
    {
        static Dictionary<int, Employee> _employee = new Dictionary<int, Employee>();
        public IActionResult Index()
        {
            return View(_employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                int id = _employee.Keys.Count != 0 ? _employee.Keys.Max() : 0;
                employee.Id = id + 1;
                _employee.Add(employee.Id, employee);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}

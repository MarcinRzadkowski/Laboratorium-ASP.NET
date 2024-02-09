using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{
    [Authorize(Roles = "admin")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_employeeService.FindAll());
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
                _employeeService.Add(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            return View(_employeeService.FindById(id));
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.Delete(employee.Id);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_employeeService.FindById(id));
        }

    }
}

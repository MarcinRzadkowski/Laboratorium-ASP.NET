using Microsoft.AspNetCore.Mvc;
using Laboratorium_4___App.Models;
using System.Reflection;

namespace Laboratorium_4___App.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            _employeeService = employee;
        }
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
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_employeeService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_employeeService.FindById(id));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            _employeeService.DeleteById(model.Id);
            return RedirectToAction("Index");
        }
    }
}

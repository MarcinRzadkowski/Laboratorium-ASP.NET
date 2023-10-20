using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Laboratorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return BadRequest();
            }
            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Laboratorium_2.Models;

namespace Laboratorium_2.Controllers
{
    public class BirthController : Controller
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
        public IActionResult Result(Birth model)
        {
            if (!model.IsValid())
            {
                return BadRequest();
            }
            return View(model);
        }
    }
}   

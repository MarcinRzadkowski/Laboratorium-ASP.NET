using Microsoft.AspNetCore.Mvc;


namespace Laboratorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "operator")] Operators op, double? a, double? b) 
        {
            if (a == null || b == null || op == null)
            {
                return View("Error");
            }
            switch (op)
            {
                case Operators.ADD:
                    ViewBag.op = a + b;
                    break;
                case Operators.SUB:
                    if (a > b)
                        ViewBag.op = a - b;
                    else
                        ViewBag.op = b - a;
                    break;
                case Operators.MUL:
                    ViewBag.op = a * b;
                    break;
                case Operators.DIV:
                    if (a > b)
                        ViewBag.op = a / b;
                    else
                        ViewBag.op = b / a;
                    break;
            }
            ViewBag.op = a + b;
            return View();
        }
    }
}

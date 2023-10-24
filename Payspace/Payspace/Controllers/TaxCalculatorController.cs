using Microsoft.AspNetCore.Mvc;
using Payspace.Models;

namespace Payspace.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CalculateTax(TaxCalculator model)
        {
            return View();
        }
    }
}

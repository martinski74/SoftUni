namespace CamerBazaar.Web.Controllers
{
    using CamerBazaar.Web.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using solid.Models;
using solid.Services;

namespace solid.Controllers
{

    //dip
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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


        public IActionResult Authenticate(string email, string password)
        {
            ShoppingContext shoppingContext = new ShoppingContext();
            AuthenticationService authenticationService = new AuthenticationService(shoppingContext);

            var status = authenticationService.Authenticate(email, password);
            if (status == "code-sent")
                return View();
            else
                return RedirectToAction("Error");
        }
    }
}

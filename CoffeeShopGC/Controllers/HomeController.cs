using System.Diagnostics;
using System.Net;
using CoffeeShopGC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeShopGC.Controllers {

   public class HomeController : Controller {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger) => _logger = logger;

      public IActionResult Index() => View();

      public IActionResult About() => View();

      public IActionResult Registration() => View();

      [HttpPost]
      public IActionResult RegistrationRespone(string email, string firstName, string lastName, string psw, string pswConfirm) {
         if( psw != pswConfirm ) {
            return new ContentResult {
               ContentType = "text/html",
               StatusCode = (int)HttpStatusCode.OK,
               Content = "<html><body><H1>Error: passwords must match</H1></body></html>"
            };
         }
         ViewData["Email"] = email;
         ViewData["FirstName"] = firstName;
         ViewData["LastName"] = lastName;
         //return View();
         return new ContentResult();
      }

      public IActionResult Privacy() => View();

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
   }
}
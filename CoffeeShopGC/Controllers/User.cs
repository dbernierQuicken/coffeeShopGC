using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopGC.Controllers {

   public class User {

      [HttpPost]
      public IActionResult RegistrationRespone(string email, string firstName, string lastName, string psw, string pswConfirm) {
         if( psw != pswConfirm ) {
            return new ContentResult {
               ContentType = "text/html",
               StatusCode = (int)HttpStatusCode.OK,
               Content = "<html><body>Error: passwords must match</body></html>"
            };
         }
         //return RergistrationRespone();
         return Json(new { Email = email, FirstName = firstName, Password = "Private" });
         //return View(email, firstName, lastName);
      }

      private IActionResult Json(object p) => throw new NotImplementedException();
   }
}
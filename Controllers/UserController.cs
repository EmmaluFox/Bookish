using Microsoft.AspNetCore.Mvc;

namespace Bookish.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserView()
        { 
            return View();
        }
    }
}
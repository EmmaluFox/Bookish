using Microsoft.AspNetCore.Mvc;

namespace Bookish.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult AuthorView()
        {
            return View();
        }
    }
}
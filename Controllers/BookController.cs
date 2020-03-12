using Microsoft.AspNetCore.Mvc;

namespace Bookish.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookView()
        { 
            return View();
        }
    }
}
using Bookish.Models;
using Bookish.Models.Users;
using Dapper;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bookish.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserView()
        { 
            return View();
        }
        
        public IActionResult NewUser()
        {
            return View();
        }
    }
}
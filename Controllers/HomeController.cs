using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
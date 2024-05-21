using Microsoft.AspNetCore.Mvc;
using WebApplication8.DAL;

namespace WebApplication8.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeamController : Controller
    {
        private readonly AppDbContex _contex;

        public TeamController(AppDbContex contex) 
        {
            this._contex = contex;
        }
        public IActionResult Index()
        {
            return View(_contex.teams.ToList());
        }

        private IActionResult View(object value)
        {
            throw new NotImplementedException();
        }

       
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CatLoversWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

//Initial commit//
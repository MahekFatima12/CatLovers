using Microsoft.AspNetCore.Mvc;

namespace CatLoversWeb.Controllers
{
    public class CareersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


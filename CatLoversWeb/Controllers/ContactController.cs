using Microsoft.AspNetCore.Mvc;

namespace CatLoversWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

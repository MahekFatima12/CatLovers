using Microsoft.AspNetCore.Mvc;
using CatLoversWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace CatLoversWeb.Controllers
{
    public class CatsController : Controller
    {
        private List<Cat> GetCats()
        {
            return new List<Cat>
            {
                new Cat { Id = 1, Name = "Luna", Breed = "Persian", Age = 2, ImageUrl = "/images/Cat1.png" },
                new Cat { Id = 2, Name = "Milo", Breed = "Bengal", Age = 3, ImageUrl = "/images/Cat2.png" },
                new Cat { Id = 3, Name = "Oliver", Breed = "Siamese", Age = 4, ImageUrl = "/images/Cat3.png" }
            };
        }

        public IActionResult Index()
        {
            return View(GetCats());
        }

        public IActionResult Details(int id)
        {
            var cat = GetCats().FirstOrDefault(c => c.Id == id);
            if (cat == null) return NotFound();
            return View(cat);
        }

        public IActionResult Edit(int id)
        {
            var cat = GetCats().FirstOrDefault(c => c.Id == id);
            if (cat == null) return NotFound();
            return View(cat);
        }
    }
}



using Microsoft.AspNetCore.Mvc;
using CatLoversWeb.Models;
using System.Collections.Generic;   // 👈 ADD THIS LINE

namespace CatLoversWeb.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            var cats = new List<Cat>
    {
        new Cat
        {
            Id = 1,
            Name = "Luna",
            Breed = "Persian",
            Age = 2,
            ImageUrl = "/images/Cat1.png"
        },
        new Cat
        {
            Id = 2,
            Name = "Milo",
            Breed = "Bengal",
            Age = 3,
            ImageUrl = "/images/Cat2.png"
        },
        new Cat
        {
            Id = 3,
            Name = "Oliver",
            Breed = "Siamese",
            Age = 4,
            ImageUrl = "/images/Cat3.png"
        }
    };

            return View(cats);
        }

    }
}


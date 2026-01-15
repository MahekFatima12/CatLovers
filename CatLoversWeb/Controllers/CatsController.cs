using Microsoft.AspNetCore.Mvc;
using CatLoversWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace CatLoversWeb.Controllers
{
    public class CatsController : Controller
    {
        // ✅ MAIN ACTION (THIS WAS MISSING)
        public IActionResult Index()
        {
            var cats = GetCats();
            return View(cats);
        }

        // ✅ OPTIONAL TEST (you can delete later)
        public IActionResult Test()
        {
            return Content("Cats controller is working ✅");
        }

        // ❌ NOT an action (correctly private)
        private List<Cat> GetCats()
        {
            return new List<Cat>
            {
                new Cat
                {
                    Id = 1,
                    Name = "Luna",
                    Breed = "Persian",
                    Age = 2,
                    ImageUrl = "/images/Cat1.png",
                    Price = 1200m,
                    DiscountPrice = 999m,
                    IsAvailable = true
                },
                new Cat
                {
                    Id = 2,
                    Name = "Milo",
                    Breed = "Bengal",
                    Age = 3,
                    ImageUrl = "/images/Cat2.png",
                    Price = 1500m,
                    DiscountPrice = null,
                    IsAvailable = false
                },
                new Cat
                {
                    Id = 3,
                    Name = "Oliver",
                    Breed = "Siamese",
                    Age = 4,
                    ImageUrl = "/images/Cat3.png",
                    Price = 800m,
                    DiscountPrice = null,
                    IsAvailable = true
                },
                new Cat
                {
                    Id = 4,
                    Name = "Kitty",
                    Breed = "American",
                    Age = 2,
                    ImageUrl = "/images/Cat4.png",
                    Price = 600m,
                    DiscountPrice = 550m,
                    IsAvailable = true
                },
                new Cat
                {
                    Id = 5,
                    Name = "Bella",
                    Breed = "Indian",
                    Age = 3,
                    ImageUrl = "/images/Cat5.png",
                    Price = 500m,
                    DiscountPrice = null,
                    IsAvailable = true
                },
                new Cat
                {
                    Id = 6,
                    Name = "Pussa",
                    Breed = "British",
                    Age = 3,
                    ImageUrl = "/images/Cat6.png",
                    Price = 1400m,
                    DiscountPrice = 1200m,
                    IsAvailable = false
                }
            };
        }
    }
}




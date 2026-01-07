////using Microsoft.AspNetCore.Mvc;

////namespace CatLoversAPI.Controllers
////{
////    public class CatsController : Controller
////    {
////        public IActionResult Index()
////        {
////            return View();
////        }
////    }
////}
//using CatLoversAPI.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace CatLoversAPI.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class CatsController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult GetCats()
//        {
//            var cats = new List<Cat>
//            {
//                new Cat { Id = 1, Name = "Milo", Age = 2, Breed = "Persian" },
//                new Cat { Id = 2, Name = "Luna", Age = 3, Breed = "Siamese" }
//            };

//            return Ok(cats);
//        }
//    }
//}
//[HttpPost]
//public IActionResult AddCat([FromBody] Cat cat)
//{
//    if (cat == null)
//    {
//        return BadRequest("Cat data is required");
//    }

//    // For now, just return the same cat (later we’ll save to SQL)
//    return Ok(cat);
//}
//using CatLoversAPI.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace CatLoversAPI.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class CatsController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult GetCats()
//        {
//            var cats = new List<Cat>
//            {
//                new Cat { Id = 1, Name = "Milo", Age = 2, Breed = "Persian" },
//                new Cat { Id = 2, Name = "Luna", Age = 3, Breed = "Siamese" }
//            };

//            return Ok(cats);
//        }

//        [HttpPost]
//        public IActionResult AddCat([FromBody] Cat cat)
//        {
//            if (cat == null)
//            {
//                return BadRequest("Cat data is required");
//            }

//            return Ok(cat);
//        }
//    }
//}
using CatLoversAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CatLoversAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatsController : ControllerBase
    {
        // Shared in-memory list (acts like a fake database for now)
        private static List<Cat> cats = new List<Cat>
        {
            new Cat { Id = 1, Name = "Milo", Age = 2, Breed = "Persian" },
            new Cat { Id = 2, Name = "Luna", Age = 3, Breed = "Siamese" }
        };

        // GET: api/Cats
        [HttpGet]
        public IActionResult GetCats()
        {
            return Ok(cats);
        }

        // POST: api/Cats
        [HttpPost]
        public IActionResult AddCat([FromBody] Cat cat)
        {
            if (cat == null)
            {
                return BadRequest("Cat data is required");
            }

            cats.Add(cat);
            return Ok(cat);
        }

        // PUT: api/Cats/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCat(int id, [FromBody] Cat updatedCat)
        {
            var cat = cats.FirstOrDefault(c => c.Id == id);

            if (cat == null)
            {
                return NotFound("Cat not found");
            }

            cat.Name = updatedCat.Name;
            cat.Age = updatedCat.Age;
            cat.Breed = updatedCat.Breed;

            return Ok(cat);
        }

        // DELETE: api/Cats/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCat(int id)
        {
            var cat = cats.FirstOrDefault(c => c.Id == id);

            if (cat == null)
            {
                return NotFound("Cat not found");
            }

            cats.Remove(cat);
            return Ok($"Cat with Id {id} deleted successfully");
        }
    }
}


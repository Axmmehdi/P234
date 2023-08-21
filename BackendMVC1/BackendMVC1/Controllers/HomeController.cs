using BackendMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendMVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _marks;

        public HomeController()
        {
            _marks = new List<Marka>
            {
              new Marka{Id = 1,Name="BMW", Country="Germany",ProductionYear=1916},
              new Marka{Id = 2,Name="Mercedes", Country="Germany",ProductionYear=1900},
              new Marka{Id = 3,Name="Audi", Country="Germany",ProductionYear=1901},
              new Marka{Id = 4,Name="Toyota", Country="Japaness",ProductionYear=1936},
              new Marka{Id = 5,Name="Nissan", Country="Japaness",ProductionYear=1910},
              new Marka{Id = 6,Name="Ford", Country="USA",ProductionYear=1903},
              new Marka{Id = 7,Name="Chevrolet", Country="USA",ProductionYear=1911},
            };
        }
        public IActionResult Index()
        {

            return View(_marks);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return BadRequest("Marka Id mutleq gonderilmelidir");
            Marka marks = _marks.Find(m => m.Id == id);
            if (marks == null) return NotFound();
            return View(marks);
        }
    }
}

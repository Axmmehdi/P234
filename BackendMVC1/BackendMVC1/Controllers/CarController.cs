using BackendMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendMVC1.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,Count=103},
                new Car{Id = 2,Count=200},
                new Car{Id = 3,Count=340},
                new Car{Id = 4,Count=165},
                new Car{Id = 5,Count=273},
                new Car{Id = 6,Count=532},
                new Car{Id = 7,Count=172},
            };
        }

        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest("Car Id mutleq gonderilmelidir");
            Car car = _cars.Find(m => m.Id == id);
            if (car == null) return NotFound();
            return View();
        }
    }
}

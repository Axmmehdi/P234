using BackendMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BackendMVC1.Controllers
{
    public class CarModelsController : Controller
    {
        private readonly List<CarModel> _carmodel;
        public CarModelsController()
        {
            _carmodel = new List<CarModel> 
            {
                new CarModel{Id=1, MarkaID = 1,Name="Model F90 M5 ",Year=2022,HPD=790},
                new CarModel{Id=2, MarkaID = 2,Name="Model GlS63",Year=2020, HPD=689},
                new CarModel{Id=3, MarkaID = 3,Name="Model GlS63",Year=2022,HPD=767},
                new CarModel{Id=4, MarkaID = 4,Name="Model GlS63",Year=2022,HPD=789},
                new CarModel{Id=5, MarkaID = 5,Name="Model GlS63",Year=2022,HPD=668},
                new CarModel{Id=6, MarkaID = 6,Name="Model  RS6",Year=2022,HPD=458},
                new CarModel{Id=7, MarkaID = 7,Name="Model GlS63",Year=2022,HPD=358},

            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest("CarModel Id'si mutleq gonderilmelidir");
            CarModel carmodel = _carmodel.Find(m => m.Id == id);
            if (carmodel == null) return NotFound();
            return View();
           
        }
    }
}

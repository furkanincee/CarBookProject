using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        
        public CarController(ICarService carService)
        {
            _carService = carService;   
        }

        public IActionResult Index()
        {
            var values = _carService.GetAllCarsWithBrands();
            return View(values);
        }
    }
}

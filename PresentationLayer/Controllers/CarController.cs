using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarCategoryService _carCategoryService;

        public CarController(ICarService carService, ICarCategoryService carCategoryService)
        {
            _carService = carService;
            _carCategoryService = carCategoryService;
        }

        public IActionResult Index()
        {
            var values = _carService.GetAllCarsWithBrands();
            _carCategoryService.GetCategoriesWithCarCount();
            return View(values);
        }

        public IActionResult CarList()
        {
            var values = _carService.GetAllCarsWithBrands();
            return View(values);
        }

        public IActionResult CarDetail(int id)
        {
            return View();
        }
    }
}

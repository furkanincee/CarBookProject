using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly ICarDetailService _carDetailService;

        public CarController(ICarService carService, ICarCategoryService carCategoryService, ICarDetailService carDetailService)
        {
            _carService = carService;
            _carCategoryService = carCategoryService;
            _carDetailService = carDetailService;
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
            ViewBag.title1 = "Araba Detayları";
            ViewBag.title2 = "Son Araç Detayları";
            ViewBag.id = id;
            var value = _carDetailService.GetCarDetailByCarId(id);
            ViewBag.desc = value.Description;
            return View();

        }
    }
}

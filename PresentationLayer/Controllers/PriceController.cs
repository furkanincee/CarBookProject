using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresentationLayer.Controllers
{
    public class PriceController : Controller
    {
        private readonly IPriceService _priceService;
        private readonly ICarService _carService;

        public PriceController(IPriceService priceService, ICarService carService)
        {
            _priceService = priceService;
            _carService = carService;
        }
        public IActionResult Index()
        {
            var values = _priceService.GetListAll();
            return View(values);
        }

        [HttpPost]
        public IActionResult Create(Price price)
        {
            _priceService.Insert(price);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> values = (from x in _carService.GetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        public IActionResult DeletePrice(int id)
        {
            var value = _priceService.GetbyId(id);
            _priceService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            List<SelectListItem> values = (from x in _carService.GetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _priceService.GetbyId(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Price price)
        {
            _priceService.Update(price);
            return RedirectToAction("Index");
        }
    }
}

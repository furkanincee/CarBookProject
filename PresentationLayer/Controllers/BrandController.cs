using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _brandService.GetbyId(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            _brandService.Update(brand);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            _brandService.Insert(brand);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _brandService.Delete(_brandService.GetbyId(id));
            return RedirectToAction("Index");
        }
    }
}

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;
        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }
        public IActionResult Index()
        {
            var values = _carStatusService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCarStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCarStatus(CarStatus carStatus)
        {
            _carStatusService.Insert(carStatus);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCarStatus(int id)
        {
            var value = _carStatusService.GetbyId(id);
            _carStatusService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCarStatus(int id)
        {
            var value = _carStatusService.GetbyId(id);
            return View(value);

        }
        
        [HttpGet]
        public IActionResult UpdateCarStatus(CarStatus carStatus)
        {
            _carStatusService.Update(carStatus);
            return RedirectToAction("Index");

        }
    }
}

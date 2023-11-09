using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailAboutAuthorComponentPartial : ViewComponent
    {
        private readonly ICarDetailService _carDetailService;
        public _CarDetailAboutAuthorComponentPartial(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _carDetailService.GetCarDetailWithAuthor(id);
            return View(values);
        }
    }
}

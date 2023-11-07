using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.UILayout
{
    public class _CarDetailCategoryComponentPartial : ViewComponent
    {
        private readonly ICarCategoryService _carCategoryService;
        public _CarDetailCategoryComponentPartial(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _carCategoryService.GetListAll();
            return View(values);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.UILayout
{
    public class _CoverUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invok()
        {
            return View();
        }
    }
}

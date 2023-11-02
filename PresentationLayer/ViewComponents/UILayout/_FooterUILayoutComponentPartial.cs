using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.UILayout
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

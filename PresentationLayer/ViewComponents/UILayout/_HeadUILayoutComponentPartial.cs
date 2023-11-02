
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.UILayout
{
    public class _HeadUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

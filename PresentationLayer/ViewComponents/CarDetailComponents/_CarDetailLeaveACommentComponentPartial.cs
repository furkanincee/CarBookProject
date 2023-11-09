using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailLeaveACommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

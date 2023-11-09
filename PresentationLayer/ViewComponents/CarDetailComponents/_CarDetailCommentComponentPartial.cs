using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCommentComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        public _CarDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetCommentsByCar(id);
            return View(values); 
        }
    }
}

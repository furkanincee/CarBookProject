using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class UILayout : Controller
	{

        public UILayout()
        {
            
        }
        public IActionResult Index()
		{
			return View();
		}
	}
}

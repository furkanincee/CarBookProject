using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

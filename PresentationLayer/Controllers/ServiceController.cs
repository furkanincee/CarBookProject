using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IServiceService _serviceService;
		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IActionResult Index() 
		{
			var values = _serviceService.GetListAll();
			return View(values);
		}
	}
}

using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules.ServiceValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
		
		public IActionResult ServiceList() 
		{
			var values = _serviceService.GetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateService() 
		{
			return View();
		}
		
		[HttpPost]
		public IActionResult CreateService(Service service) 
		{
			CreateServiceValidator validationRules = new CreateServiceValidator();
			ValidationResult result = validationRules.Validate(service);

			if (result.IsValid)
			{
                _serviceService.Insert(service);
                return RedirectToAction();
            }

			foreach (var item in result.Errors)
			{
				ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
			}

			return View();
		}
	}
}

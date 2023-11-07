using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.ServiceComponents
{
    public class _HowItWorksStepComponentPartial : ViewComponent
    {
        private readonly IHowItWorksStepService _howItWorksStepService;
        public _HowItWorksStepComponentPartial(IHowItWorksStepService howItWorksStepService)
        {
            _howItWorksStepService = howItWorksStepService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _howItWorksStepService.GetListAll();
            return View(values);
        }
    }
}

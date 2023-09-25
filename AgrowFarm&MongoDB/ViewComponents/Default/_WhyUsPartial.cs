using AgrowFarm_MongoDB.Services.OurService;
using AgrowFarm_MongoDB.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.ViewComponents.Default
{
    public class _WhyUsPartial : ViewComponent
    {
        private readonly IWhyUsService _whyUsService;

        public _WhyUsPartial(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _whyUsService.GetAllWhyUs();
            return View(values);
        }
    }
}

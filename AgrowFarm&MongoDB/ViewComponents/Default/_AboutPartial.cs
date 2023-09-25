using AgrowFarm_MongoDB.Services.About;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAbout();
            return View(values);
        }
    }
}
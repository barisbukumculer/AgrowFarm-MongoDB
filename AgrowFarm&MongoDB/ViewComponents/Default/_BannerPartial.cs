using AgrowFarm_MongoDB.Services.Banner;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.ViewComponents.Default
{
    public class _BannerPartial : ViewComponent
    {
        private readonly IBannerService _bannerService;

        public _BannerPartial(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetAllBanner();
            return View(values);
        }
    }
}

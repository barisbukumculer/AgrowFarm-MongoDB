using AgrowFarm_MongoDB.Services.OurService;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.ViewComponents.Default
{
    public class _OurServicePartial : ViewComponent
    {
        private readonly IOurServiceService _ourServiceService;

        public _OurServicePartial(IOurServiceService ourServiceService)
        {
            _ourServiceService = ourServiceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ourServiceService.GetAllOurService();
            return View(values);
        }
    }
}

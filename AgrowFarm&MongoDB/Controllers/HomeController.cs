using AgrowFarm_MongoDB.Models;
using AgrowFarm_MongoDB.Services.About;
using AgrowFarm_MongoDB.Services.Banner;
using AgrowFarm_MongoDB.Services.OurService;
using AgrowFarm_MongoDB.Services.Statistic;
using AgrowFarm_MongoDB.Services.Testimonial;
using AgrowFarm_MongoDB.Services.VideoBanner;
using AgrowFarm_MongoDB.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgrowFarm_MongoDB.Controllers
{
    public class HomeController : Controller
    {
		private readonly ILogger<HomeController> _logger;
		private readonly IBannerService _bannerService;
		private readonly IAboutService _aboutService;
		private readonly IOurServiceService _ourServiceService;
		private readonly IStatisticService _statisticService;
		private readonly ITestimonialService _testimonialService;
		private readonly IVideoBannerService _videoBannerService;
		private readonly IWhyUsService _whyUsService;

		public HomeController(ILogger<HomeController> logger, IBannerService bannerService, IAboutService aboutService, IOurServiceService ourServiceService, IStatisticService statisticService, ITestimonialService testimonialService, IVideoBannerService videoBannerService, IWhyUsService whyUsService)
		{
			_logger = logger;
			_bannerService = bannerService;
			_aboutService = aboutService;
			_ourServiceService = ourServiceService;
			_statisticService = statisticService;
			_testimonialService = testimonialService;
			_videoBannerService = videoBannerService;
			_whyUsService = whyUsService;
		}

		public IActionResult Index()
        {
            return View();
        }
		public PartialViewResult BannerPartial()
		{
			var values = _bannerService.GetAllBanner();
			return PartialView(values);
		}
		public PartialViewResult AboutPartial()
		{
			var values = _aboutService.GetAllAbout();
			return PartialView(values);
		}
		public PartialViewResult OurServicePartial()
		{
			var values = _ourServiceService.GetAllOurService();
			return PartialView(values);
		}
		public PartialViewResult StatisticPartial()
		{
			var values = _statisticService.GetAllStatistic();
			return PartialView(values);
		}
		public PartialViewResult TestimonialPartial()
		{
			var values = _testimonialService.GetAllTestimonial();
			return PartialView(values);
		}
		public PartialViewResult VideoBannerPartial()
		{
			var values = _videoBannerService.GetAllVideoBanner();
			return PartialView(values);
		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using AgrowFarm_MongoDB.Entities;
using AgrowFarm_MongoDB.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.Controllers
{
	public class AdminWhyUsController : Controller
	{

		private readonly IWhyUsService _whyUsService;

		public AdminWhyUsController(IWhyUsService whyUsService)
		{
			_whyUsService = whyUsService;
		}

		public IActionResult Index()
		{
			var values = _whyUsService.GetAllWhyUs();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();

		}
		[HttpPost]
		public IActionResult Create(WhyUs whyUs)
		{
			_whyUsService.CreateWhyUs(whyUs);
			return View();
		}
	}
}

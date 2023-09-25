using AgrowFarm_MongoDB.Entities;
using AgrowFarm_MongoDB.Services.Testimonial;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarm_MongoDB.Controllers
{
	public class AdminTestimonialController : Controller
	{
		private readonly ITestimonialService _testimonialService;

		public AdminTestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public IActionResult Index()
		{
			var values = _testimonialService.GetAllTestimonial();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();

		}
		[HttpPost]
		public IActionResult Create(Testimonial testimonial)
		{
			_testimonialService.CreateTestimonial(testimonial);
			return View();
		}
	}
}


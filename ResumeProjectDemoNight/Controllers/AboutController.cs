using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
	public class AboutController : Controller
	{
		private readonly ResumeContext _context;
		public AboutController(ResumeContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var value = _context.Abouts.FirstOrDefault();
			return View(value);
		}

		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = _context.Abouts.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			var value = _context.Abouts.Find(about.AboutId);

			value.NameSurname = about.NameSurname;
			value.Title = about.Title;
			value.ImageUrl = about.ImageUrl;
			value.Description = about.Description;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}

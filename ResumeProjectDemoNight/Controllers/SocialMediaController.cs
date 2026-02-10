using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;
using System.Linq;

namespace ResumeProjectDemoNight.Controllers
{
	public class SocialMediaController : Controller
	{
		private readonly ResumeContext _context;

		public SocialMediaController(ResumeContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.SocialMedias.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia socialMedia)
		{
			_context.SocialMedias.Add(socialMedia);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSocialMedia(int id)
		{
			var value = _context.SocialMedias.Find(id);
			_context.SocialMedias.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var value = _context.SocialMedias.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			var value = _context.SocialMedias.Find(socialMedia.SocialMediaId);
			value.Name = socialMedia.Name;
			value.Url = socialMedia.Url;
			value.Icon = socialMedia.Icon;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
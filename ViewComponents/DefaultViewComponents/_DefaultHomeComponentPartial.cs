using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
	public class _DefaultHomeComponentPartial : ViewComponent
	{
		private readonly ResumeContext _context;

		public _DefaultHomeComponentPartial(ResumeContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{

			var aboutValue = _context.Abouts.FirstOrDefault();


			var socialMediaValues = _context.SocialMedias.ToList();


			ViewBag.SocialMedia = socialMediaValues;


			return View(aboutValue);
		}
	}
}
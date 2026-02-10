using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
	public class _DefaultAboutComponentPartial : ViewComponent
	{
		private readonly ResumeContext _context;

		public _DefaultAboutComponentPartial(ResumeContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var aboutValue = _context.Abouts.FirstOrDefault();
			var skillValues = _context.Skills.ToList();
			ViewBag.SkillList = skillValues;
			return View(aboutValue);
		}
	}
}



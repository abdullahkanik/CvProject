using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
	public class DashboardController : Controller
	{
		private readonly ResumeContext _context;

		public DashboardController(ResumeContext context)
		{
			_context = context;
		}

		public IActionResult DashboardList()
		{
			var model = new Dashboard
			{
				TotalMessages = _context.Messages.Count(),
				UnreadMessages = _context.Messages.Count(x => x.IsRead == false),

				ExperienceCount = _context.Experiences.Count(),
				SkillCount = _context.Skills.Count(),

				About = _context.Abouts.OrderByDescending(x => x.AboutId).FirstOrDefault(),

				RecentMessages = _context.Messages
				   .OrderBy(x => x.IsRead)            // okunmamışlar üstte
				   .ThenByDescending(x => x.SendDate) // sonra tarihe göre
				   .Take(8)
				   .ToList()
			};

			return View(model);
		}
	}
}
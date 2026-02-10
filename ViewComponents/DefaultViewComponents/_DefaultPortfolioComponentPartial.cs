using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;
using System.Linq;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
	public class _DefaultPortfolioComponentPartial : ViewComponent
	{
		private readonly ResumeContext _context;

		public _DefaultPortfolioComponentPartial(ResumeContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			ViewBag.Categories = _context.PortfolioCategories.ToList();

			var values = _context.Portfolios
				.Include(x => x.PortfolioCategory)
				.ToList();

			return View(values);
		}
	}
}

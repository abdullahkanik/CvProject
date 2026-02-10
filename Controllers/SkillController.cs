using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;
using System.Linq;

namespace ResumeProjectDemoNight.Controllers
{
	public class SkillController : Controller
	{
		private readonly ResumeContext _context;

		public SkillController(ResumeContext context)
		{
			_context = context;
		}

		// LIST
		[HttpGet]
		public IActionResult Index()
		{
			var values = _context.Skills.ToList();
			return View(values);
		}

		// ADD - GET
		[HttpGet]
		public IActionResult AddSkill()
		{
			// View: @model Skill olmalı
			return View(new Skill());
		}

		// ADD - POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddSkill(Skill skill)
		{
			if (!ModelState.IsValid)
				return View(skill);

			_context.Skills.Add(skill);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// DELETE
		[HttpGet]
		public IActionResult DeleteSkill(int id)
		{
			var value = _context.Skills.Find(id);
			if (value == null)
				return NotFound();

			_context.Skills.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// UPDATE - GET
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var value = _context.Skills.Find(id);
			if (value == null)
				return NotFound();

			return View(value);
		}

		// UPDATE - POST  (EN SAĞLAM YÖNTEM)
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpdateSkill(Skill skill)
		{
			if (!ModelState.IsValid)
				return View(skill);

			// DB'den asıl kaydı çek, alanları güncelle
			var value = _context.Skills.Find(skill.SkillId);
			if (value == null)
				return NotFound();

			value.Title = skill.Title;
			value.Value = skill.Value;

			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}

namespace ResumeProjectDemoNight.Entities
{
	public class Dashboard
	{
		public int DashboardId { get; set; }
		public int TotalMessages { get; set; }
		public int UnreadMessages { get; set; }

		public int ExperienceCount { get; set; }
		public int SkillCount { get; set; }

		public About? About { get; set; }

		public List<Message> RecentMessages { get; set; } = new();
	}
}

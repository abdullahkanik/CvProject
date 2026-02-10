namespace ResumeProjectDemoNight.Entities
{
	public class PortfolioCategory
	{
		public int PortfolioCategoryId { get; set; }
		public string Name { get; set; }

		public List<Portfolio> Portfolios { get; set; }
	}

}

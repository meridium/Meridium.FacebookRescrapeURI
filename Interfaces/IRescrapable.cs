namespace Meridium.FacebookRescrapeURI.Interfaces
{
	public interface IRescrapable
	{
		bool IsPopulated { get; }
		string OpenGraphKey { get; set; }

		bool IsValidForScraping();
	}
}

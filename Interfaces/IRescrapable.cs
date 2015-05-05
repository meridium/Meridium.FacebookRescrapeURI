namespace Meridium.FacebookRescrapeURI.Interfaces
{
	public interface IRescrapable
	{
		string OpenGraphKey { get; set; }

		bool IsValidForScraping();
	}
}

using Meridium.FacebookRescrapeURI.Interfaces;

namespace Meridium.FacebookRescrapeURI
{
	public class RescrapableObject : IRescrapable
	{
		public string OpenGraphKey { get; set; }

		public bool IsValidForScraping()
		{
			return !string.IsNullOrEmpty(OpenGraphKey);
		}
	}
}

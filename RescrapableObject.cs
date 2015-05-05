using Meridium.FacebookRescrapeURI.Interfaces;

namespace Meridium.FacebookRescrapeURI
{
	public class RescrapableObject : IRescrapable
	{
		public bool IsPopulated { get; set; }
		public string OpenGraphKey { get; set; }

		public bool IsValidForScraping()
		{
			return IsPopulated && !string.IsNullOrEmpty(OpenGraphKey);
		}
	}
}

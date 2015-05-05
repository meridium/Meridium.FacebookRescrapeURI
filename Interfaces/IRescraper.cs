using log4net;

namespace Meridium.FacebookRescrapeURI.Interfaces
{
	public interface IRescraper
	{
		void Rescrape();
		ILog Logger { get; set; }
		int Timeout { get; set; }
	}
}

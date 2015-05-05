using System;
using System.Net;
using log4net;
using Meridium.FacebookRescrapeURI.Interfaces;

namespace Meridium.FacebookRescrapeURI
{
    public class Rescraper : IRescraper
    {
	    private ILog _logger;
	    public ILog Logger
	    {
		    get
		    {
			    if (_logger != null)
			    {
				    return _logger;
			    }
				_logger = LogManager.GetLogger(typeof(Rescraper));
				return _logger;
		    }
		    set { _logger = value; }
	    }

		private IRescrapable ScrapableObject { get; set; }
	    public int Timeout { get; set; }

	    public static IRescraper Create(IRescrapable rescrapableObject)
	    {
			return new Rescraper(rescrapableObject);
	    }

	    public static IRescraper Create(string openGraphKey)
	    {
			return new Rescraper(openGraphKey);
	    }

		private Rescraper(string openGraphKey)
		{
			ScrapableObject = CreateRescrapableObject(openGraphKey);
		}

		private Rescraper(IRescrapable rescrapableObject)
		{
			ScrapableObject = rescrapableObject;
		}

	    public void Rescrape()
	    {
		    if (!ScrapableObject.IsValidForScraping())
		    {
			    return;
		    }

			var scrapeUrl = "http://graph.facebook.com?id=" + ScrapableObject.OpenGraphKey + "&scrape=true";
			var requestUri = new Uri(scrapeUrl);
			var webRequest = WebRequest.Create(requestUri);
			webRequest.Method = "POST";
			webRequest.Timeout = Timeout > 0 ? Timeout : 100000;

			try
			{
				var webResponse = webRequest.GetResponse();
				Logger.InfoFormat("Open Graph: Scraping update for {0} completed.\nStatus: {1}", ScrapableObject.OpenGraphKey, ((HttpWebResponse)webResponse).StatusDescription);
			}
			catch (WebException ex)
			{
				Logger.ErrorFormat("Open Graph: Scraping update for {0} failed.\n{1}", ScrapableObject.OpenGraphKey, ex.Message);
			}
	    }

		public static IRescrapable CreateRescrapableObject(string openGraphKey)
		{
			return new RescrapableObject()
			{
				OpenGraphKey = openGraphKey
			};
		}

    }
}

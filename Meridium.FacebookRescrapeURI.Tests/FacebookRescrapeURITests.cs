using NUnit.Framework;

namespace Meridium.FacebookRescrapeURI.Tests
{
	[TestFixture]
	public class FacebookRescrapeURITests
	{
		[Test]
		public void Assert_RescrapeObject_IsValid()
		{
			var rescrapeObject = Rescraper.CreateRescrapableObject("http://www.meridium.se");
			Assert.IsTrue(rescrapeObject.IsValidForScraping());
		}

		[Test]
		public void Assert_RescrapeObject_IsInValid()
		{
			var rescrapeObject = Rescraper.CreateRescrapableObject(null);
			Assert.IsFalse(rescrapeObject.IsValidForScraping());
		}
	}
}

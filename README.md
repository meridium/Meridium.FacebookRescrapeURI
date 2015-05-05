# Rescraper for Facebook Open Graph


## Object instance

<code>var openGraphObject = new Meridium.FacebookRescrapeURI.RescrapableObject()
{
	IsPopulated = true|false,
	OpenGraphKey = URL to page | ID from Open Graph
};</code>

## Usage

<code>var rescraperInstance = Meridium.FacebookRescrapeURI.Rescraper.Create(openGraphObject);
rescraperInstance.Timeout = 20; // Defaults to WebRequest.Timeout default (100 000 miliseconds)
rescraperInstance.Rescrape();</code>

## Component <3 EPiServer


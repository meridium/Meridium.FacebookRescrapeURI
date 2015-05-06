# Re-scraper for Facebook Open Graph

A "wrapper" for sending requests to Facebook and Open Graph to update an OG-object.

According to Facebook, the crawler will re-scrape (and therefore update) objects:

- When the object URL is input in the Object Debugger
- Every 30 days after the first scrape
- When an app triggers a scrape using an API endpoint (this is doin' that)

Source: [Facebook Developers: Using Objects -> Updating Objects](https://developers.facebook.com/docs/sharing/opengraph/using-objects#update)

## Usage

The Open Graph endpoint takes one param; the URL or ID of the stored Open Graph object.
This function does the same (why complicate things?).

<code>var rescraperInstance = Meridium.FacebookRescrapeURI.Rescraper.Create([URL or OG Id]);
rescraperInstance.Rescrape();</code>

## Setting custom Timeout value

Sometimes you need (or want) to take control over the timeout. You can do that.

`rescraperInstance.Timeout = (int)(0 -> System.Threading.Timeout.Infinite)(default: 100 000 ms)`

## Installation

Find it in our internal NuGet-feed. 

`Install-Package Meridium.FacebookRescrapeURI`

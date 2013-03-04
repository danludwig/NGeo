using System;
using System.Globalization;
using System.Text;

namespace NGeo.Yahoo.PlaceFinder
{
    internal static class EndpointUrlBuilder
    {
        internal static Uri GetUri(this PlaceByCoordinates request)
        {
            return GetQLocationUri(request, request.Location);
        }

        internal static Uri GetUri(this PlaceByFreeformText request)
        {
            return GetQLocationUri(request, request.Location);
        }

        private static Uri GetQLocationUri(PlaceBy request, string location)
        {
            const string template = "q={location}";

            var urlBuilder = new StringBuilder(GetBaseUrl(request, template));
            urlBuilder.Replace("{location}", location);

            return new Uri(urlBuilder.ToString());
        }

        internal static Uri GetUri(this PlaceByName request)
        {
            const string template = "name={name}";

            var urlBuilder = new StringBuilder(GetBaseUrl(request, template));
            urlBuilder.Replace("{name}", request.Name);

            return new Uri(urlBuilder.ToString());
        }

        internal static Uri GetUri(this PlaceByWoeId request)
        {
            const string template = "woeid={woeid}";

            var urlBuilder = new StringBuilder(GetBaseUrl(request, template));
            urlBuilder.Replace("{woeid}", request.WoeId.ToString(CultureInfo.InvariantCulture));

            return new Uri(urlBuilder.ToString());
        }

        internal static Uri GetUri(this PlaceByMultilineAddress request)
        {
            const string template = "line1={line1}&line2={line2}&line3={line3}";

            var urlBuilder = new StringBuilder(GetBaseUrl(request, template));
            urlBuilder.Replace("{line1}", request.Line1);
            urlBuilder.Replace("{line2}", request.Line2);
            urlBuilder.Replace("{line3}", request.Line3);

            return new Uri(urlBuilder.ToString());
        }

        internal static Uri GetUri(this PlaceByFullyParsedAddress request)
        {
            const string template = "house={house}&street={street}&unittype={unitType}&unit={unit}" +
                "&xstreet={crossStreet}&postal={postal}&neighborhood={neighborhood}&city={city}&county={county}&state={state}&country={country}";

            var urlBuilder = new StringBuilder(GetBaseUrl(request, template));
            urlBuilder.Replace("{house}", request.House);
            urlBuilder.Replace("{street}", request.Street);
            urlBuilder.Replace("{unitType}", request.UnitType);
            urlBuilder.Replace("{unit}", request.Unit);
            urlBuilder.Replace("{crossStreet}", request.CrossStreet);
            urlBuilder.Replace("{postal}", request.Postal);
            urlBuilder.Replace("{neighborhood}", request.Neighborhood);
            urlBuilder.Replace("{city}", request.City);
            urlBuilder.Replace("{county}", request.County);
            urlBuilder.Replace("{state}", request.StateOrProvince);
            urlBuilder.Replace("{country}", request.Country);

            return new Uri(urlBuilder.ToString());
        }

        private static string GetBaseUrl(PlaceBy request, string template)
        {
            var urlBuilder = new StringBuilder(template);

            urlBuilder.Append("&locale={locale}&start={start}&count={count}");
            urlBuilder.Append("&offset={offset}&flags={flags}&gflags={gFlags}");

            urlBuilder.Replace("{locale}", request.Locale);
            urlBuilder.Replace("{start}", request.Start.ToString(CultureInfo.InvariantCulture));
            urlBuilder.Replace("{count}", request.Count.ToString(CultureInfo.InvariantCulture));
            urlBuilder.Replace("{offset}", request.Offset.ToString(CultureInfo.InvariantCulture));
            urlBuilder.Replace("{flags}", request.GetFlagsAsString());
            urlBuilder.Replace("{gFlags}", request.GetGFlagsAsString());

            urlBuilder.Insert(0, "http://yboss.yahooapis.com/geo/placefinder?");
            return urlBuilder.ToString();
        }
    }
}

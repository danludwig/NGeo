using System;
using System.Collections.ObjectModel;
using System.Net;
using System.ServiceModel;

namespace NGeo.GeoNames
{
    /// <summary>
    /// Client for invoking GeoNames services from .NET code.
    /// </summary>
    /// <example>
    /// using (var geoNamesClient = new GeoNamesClient())
    /// {
    ///     var toponym = geoNamesClient.Get(6295630, "demo");
    /// }
    /// </example>
    public class GeoNamesClient : ClientBase<IInvokeGeoNamesServices>, IConsumeGeoNames
    {
        private const int RetryLimit = 5;
        private const string ClosedConnectionMessage = "The underlying connection was closed: A connection that was expected to be kept alive was closed by the server.";

        /// <summary>
        /// Find nearby populated place / reverse geocoding. See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#findNearbyPlaceName">Official
        /// GeoNames  findNearbyPlaceName Documentation</seealso> for more information.
        /// </summary>
        /// <param name="finder">Arguments sent to the GeoNames service.</param>
        /// <returns>The closest populated place for the lat/lng query as xml document. The unit of the
        /// distance element is 'km'.</returns>
        public ReadOnlyCollection<Toponym> FindNearbyPlaceName(NearbyPlaceNameFinder finder)
        {
            if (finder == null) throw new ArgumentNullException("finder");

            var response = ChannelFindNearbyPlaceName(finder);

            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Toponym>(results) : null;
        }

        private Results<Toponym> ChannelFindNearbyPlaceName(NearbyPlaceNameFinder finder, int retry = 0)
        {
            try
            {
                if (finder.RadiusInKm.HasValue)
                    return Channel.FindNearbyPlaceName(finder.Latitude, finder.Longitude, finder.Language,
                        finder.RadiusInKm.Value, finder.MaxRows, finder.Style, finder.UserName);

                return Channel.FindNearbyPlaceName(finder.Latitude, finder.Longitude, finder.Language,
                    finder.MaxRows, finder.Style, finder.UserName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelFindNearbyPlaceName(finder, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Lookup a place by postal code. See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#postalCodeLookupJSON">Official
        /// GeoNames postalCodeLookup Documentation</seealso> for more information.
        /// </summary>
        /// <param name="lookup">Arguments sent to the GeoNames service.</param>
        /// <returns>The closest populated place for the postal code/country query. The unit of the
        /// distance element is 'km'.</returns>
        public ReadOnlyCollection<PostalCode> LookupPostalCode(PostalCodeLookup lookup)
        {
            if (lookup == null) throw new ArgumentNullException("lookup");

            var response = ChannelLookupPostalCode(lookup);
            var results = response.Items;
            return results != null ? new ReadOnlyCollection<PostalCode>(results) : null;
        }

        private PostalCodeResults ChannelLookupPostalCode(PostalCodeLookup lookup, int retry = 0)
        {
            try
            {
                return Channel.LookupPostalCode(lookup.PostalCode, lookup.Country,
                    lookup.MaxRows, lookup.Style, lookup.UserName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelLookupPostalCode(lookup, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Lookup a postal code by either Latitude/Longitude or Postalcode/Country/LocalCountry See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#findNearbyPostalCodes">Official
        /// GeoNames postalCodeLookup Documentation</seealso> for more information.
        /// </summary>
        /// <param name="finder">Arguments sent to the GeoNames service.</param>
        /// <returns>The closest postal codes to the given lat/lon. If the lat/lon is within a postal
        /// code it will be the first result with a zero distance. The unit of the distance element 
        /// is 'km'.</returns>
        public ReadOnlyCollection<NearbyPostalCode> FindNearbyPostalCodes(NearbyPostalCodesFinder finder)
        {
            if (finder == null) throw new ArgumentNullException("finder");

            var response = ChannelFindNearbyPostalCodes(finder);
            var results = response.Items;
            return results != null ? new ReadOnlyCollection<NearbyPostalCode>(results) : null;
        }

        private NearbyPostalCodeResults ChannelFindNearbyPostalCodes(NearbyPostalCodesFinder finder, int retry = 0)
        {
            try
            {
                if (String.IsNullOrEmpty(finder.PostalCode))
                {
                    return Channel.FindNearbyPostalCodes(finder.Latitude, finder.Longitude, finder.RadiusInKm,
                        finder.Country, finder.LocalCountry,
                        finder.MaxRows, finder.Style, finder.UserName);
                }
                return Channel.FindNearbyPostalCodes(finder.PostalCode, finder.Country, finder.RadiusInKm,
                    finder.MaxRows, finder.Style, finder.UserName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelFindNearbyPostalCodes(finder, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Postal Code Country Info (countries available with min & max postal codes). See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#postalCodeCountryInfo">Official
        /// GeoNames postalCodeCountryInfo Documentation</seealso> for more information.
        /// </summary>
        /// <param name="userName">Your user name.</param>
        /// <returns>Country information: Name, Abbreviation, Min & Max Postal Codes.</returns>
        public ReadOnlyCollection<PostalCodedCountry> PostalCodeCountryInfo(string userName)
        {
            var response = ChannelPostalCodeCountryInfo(userName);
            var results = response.Items;
            return (response.Items != null) ? results.AsReadOnly() : null;
        }

        private Results<PostalCodedCountry> ChannelPostalCodeCountryInfo(string userName, int retry = 0)
        {
            try
            {
                return Channel.PostalCodeCountryInfo(userName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelPostalCodeCountryInfo(userName, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Information about a specific GeoNames toponym, by ID.
        /// </summary>
        /// <param name="geoNameId">The GeoName ID of the toponym to get.</param>
        /// <param name="userName">Your user name.</param>
        /// <returns>The toponym for the specified geoNameId, if one exists.</returns>
        public Toponym Get(int geoNameId, string userName)
        {
            var toponym = ChannelGet(geoNameId, userName);
            return (toponym.GeoNameId > 0) ? toponym : null;
        }

        private Toponym ChannelGet(int geoNameId, string userName, int retry = 0)
        {
            try
            {
                return Channel.Get(geoNameId, userName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelGet(geoNameId, userName, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Returns the children (admin divisions and populated places) for a given geonameId. The children are the
        /// administrative divisions within an other administrative division, like the counties (ADM2) in a state (ADM1)
        /// or also the countries in a continent. The leafs are populated places, other feature classes like spots,
        /// mountains etc are not included in this service. Use
        /// the <seealso cref="http://www.geonames.org/export/geonames-search.html">search service</seealso> if you need
        /// other feature classes as well. See
        /// <seealso cref="http://www.geonames.org/export/place-hierarchy.html#children">Official GeoNames children
        /// Documentation</seealso> for more information.
        /// </summary>
        /// <param name="geoNameId">The GeoName ID of the parent.</param>
        /// <param name="userName">Your user name.</param>
        /// <param name="resultStyle">Amount of detail returned by the GeoNames service.
        /// Default value is full.</param>
        /// <param name="maxRows">Maximum results returned by the service.
        /// Default value is 200.</param>
        /// <returns>The children (admin divisions and populated places) for a given geonameId.</returns>
        public ReadOnlyCollection<Toponym> Children(int geoNameId, string userName,
            ResultStyle resultStyle = ResultStyle.Medium, int maxRows = 200)
        {
            var response = ChannelChildren(geoNameId, userName, resultStyle, maxRows);
            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Toponym>(results) : null;
        }

        private Results<Toponym> ChannelChildren(int geoNameId, string userName, ResultStyle resultStyle, int maxRows, int retry = 0)
        {
            try
            {
                return Channel.Children(geoNameId, userName, resultStyle, maxRows);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelChildren(geoNameId, userName, resultStyle, maxRows, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Country Info (Bounding Box, Capital, Area in square km, Population). See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#countryInfo">Official
        /// GeoNames countryInfo Documentation</seealso> for more information.
        /// </summary>
        /// <param name="userName">Your user name.</param>
        /// <returns>Country information : Capital, Population, Area in square km,
        /// Bounding Box of mainland (excluding offshore islands).</returns>
        public ReadOnlyCollection<Country> Countries(string userName)
        {
            var response = ChannelCountries(userName);
            var results = response.Items;
            return (response.Items != null) ? results.AsReadOnly() : null;
        }

        private Results<Country> ChannelCountries(string userName, int retry = 0)
        {
            try
            {
                return Channel.Countries(userName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelCountries(userName, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Returns all GeoNames higher up in the hierarchy of a place name. See
        /// <seealso cref="http://www.geonames.org/export/place-hierarchy.html#hierarchy">Official GeoNames
        /// hierarchy Documentation</seealso> for more information.
        /// </summary>
        /// <param name="geoNameId">The GeoName ID of the child toponym.</param>
        /// <param name="userName">Your user name.</param>
        /// <param name="resultStyle">Amount of detail returned by the GeoNames service.
        /// Default value is full.</param>
        /// <returns>All GeoNames higher up in the hierarchy of a place name.</returns>
        public Hierarchy Hierarchy(int geoNameId, string userName, ResultStyle resultStyle = ResultStyle.Medium)
        {
            var response = ChannelHierarchy(geoNameId, userName, resultStyle);
            return response.Items == null ? null : response;
        }

        private Hierarchy ChannelHierarchy(int geoNameId, string userName, ResultStyle resultStyle, int retry = 0)
        {
            try
            {
                return Channel.Hierarchy(geoNameId, userName, resultStyle);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelHierarchy(geoNameId, userName, resultStyle, ++retry);
                throw;
            }
        }

        /// <summary>
        /// Returns all GeoNames that match the search string. See
        /// <seealso cref="http://www.geonames.org/export/geonames-search.html">Official GeoNames
        /// search Documentation</seealso> for more information.
        /// </summary>
        /// <param name="searchOptions">Parameters to configure the search.</param>
        /// <returns>All GeoNames matching the name search parameter.</returns>
        public ReadOnlyCollection<Toponym> Search(SearchOptions searchOptions)
        {
            string q = "", name = "", nameEquals = "";
            switch (searchOptions.SearchType)
            {
                case SearchType.Query:
                    q = searchOptions.Text;
                    break;
                case SearchType.Name:
                    name = searchOptions.Text;
                    break;
                case SearchType.NameEquals:
                    nameEquals = searchOptions.Text;
                    break;
            }
            var response = ChannelSearch(q, name, nameEquals, searchOptions.MaxRows, searchOptions.StartRow,
                searchOptions.Language, searchOptions.Style, searchOptions.UserName);

            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Toponym>(results) : null;
        }

        private Results<Toponym> ChannelSearch(string q, string name, string nameEquals, int maxRows, int startRow,
            string lang, ResultStyle resultStyle, string userName, int retry = 0)
        {
            try
            {
                return Channel.Search(q, name, nameEquals, maxRows, startRow, lang, resultStyle, userName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return Channel.Search(q, name, nameEquals, maxRows, startRow, lang, resultStyle, userName);
                throw;
            }
        }

        /// <summary>
        /// Lookup a postal code by either Latitude/Longitude or Postalcode/Country/LocalCountry See
        /// <seealso cref="http://www.geonames.org/export/web-services.html#timezone">Official
        /// GeoNames postalCodeLookup Documentation</seealso> for more information.
        /// </summary>
        /// <param name="lookup">Arguments sent to the GeoNames service.</param>
        /// <returns>The extended timezone for the given latitude and longitude.</returns>
        public TimeZoneExtended TimeZone(TimeZoneLookup lookup)
        {
            if (lookup == null) throw new ArgumentNullException("lookup");

            var response = ChannelTimezone(lookup);
            return response != null ? response : null;
        }

        private TimeZoneExtended ChannelTimezone(TimeZoneLookup lookup, int retry = 0)
        {
            try
            {
                return Channel.TimeZone(lookup.Latitude, lookup.Longitude, lookup.RadiusInKm, 
                    lookup.Language, lookup.UserName);
            }
            catch (WebException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(ClosedConnectionMessage, StringComparison.Ordinal))
                    return ChannelTimezone(lookup, ++retry);
                throw;
            }
        }


    }
}

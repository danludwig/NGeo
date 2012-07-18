using System;
using System.Collections.ObjectModel;
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

            Results<Toponym> response;
            if (finder.RadiusInKm.HasValue)
                response = Channel.FindNearbyPlaceName(finder.Latitude, finder.Longitude, finder.Language,
                    finder.RadiusInKm.Value, finder.MaxRows, finder.Style, finder.UserName);

            else
                response = Channel.FindNearbyPlaceName(finder.Latitude, finder.Longitude, finder.Language,
                    finder.MaxRows, finder.Style, finder.UserName);

            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Toponym>(results) : null;
        }

        /// <summary>
        /// Lookup a place by postal code. See 
        /// <seealso cref="http://www.geonames.org/export/web-services.html#postalCodeLookupJSON">Official 
        /// GeoNames postalCodeLookup Documentation</seealso> for more information.
        /// </summary>
        /// <param name="lookup">Arguments sent to the GeoNames service.</param>
        /// <returns>The closest populated place for the postal code/country query. The unit of the 
        /// distance element is 'km'.</returns>
        public ReadOnlyCollection<Code> PostalCodeLookup(PostalCodeLookup lookup)
        {
            if (lookup == null) throw new ArgumentNullException("lookup");

            var response = Channel.PostalCodeLookup(lookup.PostalCode, lookup.Country,
                    lookup.MaxRows, lookup.Style, lookup.UserName);
            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Code>(results) : null;
        }

        /// <summary>
        /// Postal Code Country Info (countries available with min & max postal codes). See 
        /// <seealso cref="http://www.geonames.org/export/web-services.html#postalCodeCountryInfo">Official 
        /// GeoNames postalCodeCountryInfo Documentation</seealso> for more information.
        /// </summary>
        /// <param name="userName">Your user name.</param>
        /// <returns>Country information: Name, Abbreviation, Min & Max Postal Codes.</returns>
        public ReadOnlyCollection<Country> PostalCodeCountryInfo(string userName)
        {
            var response = Channel.PostalCodeCountryInfo(userName);
            var results = response.Items;
            return (response.Items != null) ? results.AsReadOnly() : null;
        }

        /// <summary>
        /// Information about a specific GeoNames toponym, by ID.
        /// </summary>
        /// <param name="geoNameId">The GeoName ID of the toponym to get.</param>
        /// <param name="userName">Your user name.</param>
        /// <returns>The toponym for the specified geoNameId, if one exists.</returns>
        public Toponym Get(int geoNameId, string userName)
        {
            var toponym = Channel.Get(geoNameId, userName);
            return (toponym.GeoNameId > 0) ? toponym : null;
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
            var response = Channel.Children(geoNameId, userName, resultStyle, maxRows);
            var results = response.Items;
            return results != null ? new ReadOnlyCollection<Toponym>(results) : null;
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
            var response = Channel.Countries(userName);
            var results = response.Items;
            return (response.Items != null) ? results.AsReadOnly() : null;
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
            var response = Channel.Hierarchy(geoNameId, userName, resultStyle);
            return response.Items == null ? null : response;
        }

    }
}

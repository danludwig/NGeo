using System;
using System.Collections.ObjectModel;

namespace NGeo.GeoNames
{
    public interface IConsumeGeoNames : IDisposable
    {
        ReadOnlyCollection<Toponym> FindNearbyPlaceName(NearbyPlaceNameFinder finder);

        ReadOnlyCollection<PostalCode> LookupPostalCode(PostalCodeLookup lookup);

        ReadOnlyCollection<NearbyPostalCode> FindNearbyPostalCodes(NearbyPostalCodesFinder finder);

        ReadOnlyCollection<PostalCodedCountry> PostalCodeCountryInfo(string userName);

        Toponym Get(int geoNameId, string userName);

        ReadOnlyCollection<Toponym> Children(int geoNameId, string userName,
            ResultStyle resultStyle = ResultStyle.Medium, int maxRows = 200);

        ReadOnlyCollection<Country> Countries(string userName);

        Hierarchy Hierarchy(int geoNameId, string userName, ResultStyle resultStyle = ResultStyle.Medium);

        ReadOnlyCollection<Toponym> Search(SearchOptions searchOptions);
    }
}
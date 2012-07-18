using System;
using System.Collections.ObjectModel;

namespace NGeo.GeoNames
{
    public interface IContainGeoNames : IDisposable
    {
        ReadOnlyCollection<Toponym> FindNearbyPlaceName(NearbyPlaceNameFinder finder);

        ReadOnlyCollection<Code> PostalCodeLookup(PostalCodeLookup lookup);

        ReadOnlyCollection<Country> PostalCodeCountryInfo();

        Toponym Get(int geoNameId);

        ReadOnlyCollection<Toponym> Children(int geoNameId,
            ResultStyle resultStyle = ResultStyle.Medium, int maxRows = 200);

        ReadOnlyCollection<Country> Countries();

        Hierarchy Hierarchy(int geoNameId, ResultStyle resultStyle = ResultStyle.Medium);

    }
}
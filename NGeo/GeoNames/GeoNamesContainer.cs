using System.Collections.ObjectModel;

namespace NGeo.GeoNames
{
    public sealed class GeoNamesContainer : IContainGeoNames
    {
        private readonly string _userName;
        private readonly IConsumeGeoNames _client;

        public GeoNamesContainer(string userName)
        {
            _userName = userName;
            _client = new GeoNamesClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public ReadOnlyCollection<Toponym> FindNearbyPlaceName(NearbyPlaceNameFinder finder)
        {
            if (finder != null) finder.UserName = _userName;
            return _client.FindNearbyPlaceName(finder);
        }

        public ReadOnlyCollection<PostalCode> LookupPostalCode(PostalCodeLookup lookup)
        {
            if (lookup != null) lookup.UserName = _userName;
            return _client.LookupPostalCode(lookup);
        }

        public ReadOnlyCollection<PostalCodedCountry> PostalCodeCountryInfo()
        {
            return _client.PostalCodeCountryInfo(_userName);
        }

        public Toponym Get(int geoNameId)
        {
            return _client.Get(geoNameId, _userName);
        }

        public ReadOnlyCollection<Toponym> Children(int geoNameId, ResultStyle resultStyle = ResultStyle.Medium, int maxRows = 200)
        {
            return _client.Children(geoNameId, _userName, resultStyle, maxRows);
        }

        public ReadOnlyCollection<Country> Countries()
        {
            return _client.Countries(_userName);
        }

        public Hierarchy Hierarchy(int geoNameId, ResultStyle resultStyle = ResultStyle.Medium)
        {
            return _client.Hierarchy(geoNameId, _userName, resultStyle);
        }
    }
}

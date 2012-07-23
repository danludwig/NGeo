﻿using System;
using System.Collections.ObjectModel;

namespace NGeo.GeoNames
{
    public interface IConsumeGeoNames : IDisposable
    {
        ReadOnlyCollection<Toponym> FindNearbyPlaceName(NearbyPlaceNameFinder finder);

        ReadOnlyCollection<Code> PostalCodeLookup(PostalCodeLookup lookup);

        ReadOnlyCollection<Country> PostalCodeCountryInfo(string userName);

        Toponym Get(int geoNameId, string userName);

        ReadOnlyCollection<Toponym> Children(int geoNameId, string userName, 
            ResultStyle resultStyle = ResultStyle.Medium, int maxRows = 200);

        ReadOnlyCollection<Country> Countries(string userName);

        Hierarchy Hierarchy(int geoNameId, string userName, ResultStyle resultStyle = ResultStyle.Medium);

    }
}
namespace NGeo.Yahoo.PlaceFinder
{
    public enum QualityDescription
    {
        NotAnAddress = 0,
        CountryLevel0IgnoreLevel1 = 9,
        CountryLevel0 = 10,
        StateOrProvinceLevel1IgnoreLevel2 = 19,
        StateOrProvinceLevel1 = 20,
        CountyLevel2IgnoreLevel3 = 29,
        CountyLevel2 = 30,
        CityTownOrLocalityLevel3IgnoreLevel4 = 39,
        CityTownOrLocalityLevel3 = 40,
        NeighborhoodLevel4IgnoreStreet = 49,
        NeighborhoodLevel4 = 50,
        PostalDistrictIgnoreStreet = 59,
        PostalDistrict = 60,
        Airport = 62,
        AreaOfInterest = 63,
        PostalZoneOrSectorIgnoreStreet = 64,

        StreetMismatch = 70,
        StreetMismatchIgnoreAddress = 71,
        StreetMatch = 72,
        PostalUnitOrSegmentIgnoreStreet = 74,
        PostalUnitOrSegment = 75,

        IntersectionWithStreetMismatch = 80,
        IntersectionWithStreetMatch = 82,
        AddressMismatchWithStreetMismatch = 84,
        AddressMatchWithStreetMismatch = 85,
        AddressMismatchWithStreetMatch = 86,
        AddressMatchWithStreetMatch = 87,
        PointOfInterest = 90,
        Coordinate = 99,
    }
}
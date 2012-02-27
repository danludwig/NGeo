using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public enum ConcordanceNamespace
    {
        [EnumMember(Value = "woeid")]
        WoeId = 0,

        [EnumMember(Value = "geonames")]
        GeoNames = 1,

        [EnumMember(Value = "iso")]
        Iso = 2,

        [EnumMember(Value = "fips10")]
        Fips10 = 3,

        [EnumMember(Value = "osm")]
        OpenStreetMapId = 4,

        [EnumMember(Value = "wiki")]
        WikipediaPageId = 5,

        [EnumMember(Value = "cctld")]
        IanaTld = 6,

    }
}

using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [DataContract]
    internal class JsonPlace
    {
        [DataMember(Name = "woeid")]
        internal int WoeId { get; set; }

        [DataMember(Name = "name")]
        internal string Name { get; set; }

        [DataMember(Name = "lang")]
        internal string Language { get; set; }

        [DataMember(Name = "uri")]
        internal Uri Uri { get; set; }

        [DataMember(Name = "centroid")]
        internal Point Center { get; set; }

        [DataMember(Name = "boundingBox")]
        internal BoundingBox BoundingBox { get; set; }

        [DataMember(Name = "areaRank")]
        internal int AreaRank { get; set; }

        [DataMember(Name = "popRank")]
        internal int PopulationRank { get; set; }

        [DataMember(Name = "postal")]
        internal string Postal { get; set; }

        [DataMember(Name = "placeTypeName")]
        internal string TypeName { get; set; }

        [DataMember(Name = "placeTypeName attrs")]
        internal JsonPlaceTypeAttributes Type { get; set; }

        [DataMember(Name = "country")]
        internal string CountryName { get; set; }

        [DataMember(Name = "country attrs")]
        internal JsonAdminAttributes Country { get; set; }

        [DataMember(Name = "admin1")]
        internal string Admin1Name { get; set; }

        [DataMember(Name = "admin1 attrs")]
        internal JsonAdminAttributes Admin1 { get; set; }

        [DataMember(Name = "admin2")]
        internal string Admin2Name { get; set; }

        [DataMember(Name = "admin2 attrs")]
        internal JsonAdminAttributes Admin2 { get; set; }

        [DataMember(Name = "admin3")]
        internal string Admin3Name { get; set; }

        [DataMember(Name = "admin3 attrs")]
        internal JsonAdminAttributes Admin3 { get; set; }

        [DataMember(Name = "locality1")]
        internal string Locality1Name { get; set; }

        [DataMember(Name = "locality1 attrs")]
        internal JsonLocalityAttributes Locality1 { get; set; }

        [DataMember(Name = "locality2")]
        internal string Locality2Name { get; set; }

        [DataMember(Name = "locality2 attrs")]
        internal JsonLocalityAttributes Locality2 { get; set; }

    }
}

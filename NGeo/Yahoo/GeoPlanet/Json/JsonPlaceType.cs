using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [DataContract]
    internal class JsonPlaceType
    {
        [DataMember(Name = "placeTypeName")]
        internal string Name { get; set; }

        [DataMember(Name = "lang")]
        internal string Language { get; set; }

        [DataMember(Name = "uri")]
        internal Uri Uri { get; set; }

        [DataMember(Name = "placeTypeDescription")]
        internal string Description { get; set; }

        [DataMember(Name = "placeTypeName attrs")]
        internal JsonPlaceTypeAttributes JsonAttributes { get; set; }

    }
}

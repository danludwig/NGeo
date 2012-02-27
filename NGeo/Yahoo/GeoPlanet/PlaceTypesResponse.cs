using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class PlaceTypesResponse
    {
        [DataMember(Name = "placeTypes")]
        internal PlaceTypes Results { get; set; }
    }
}

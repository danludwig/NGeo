using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class PlacesResponse
    {
        [DataMember(Name = "places")]
        internal Places Results { get; set; }
    }
}

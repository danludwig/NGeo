using System.Runtime.Serialization;
using NGeo.Yahoo.GeoPlanet.Json;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class PlaceResponse
    {
        [DataMember(Name = "place")]
        internal JsonPlace Result { get; set; }

    }
}
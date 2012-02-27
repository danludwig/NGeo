using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [DataContract]
    internal class JsonPlaceTypeAttributes
    {
        [DataMember(Name = "code")]
        internal int Code { get; set; }
    }
}

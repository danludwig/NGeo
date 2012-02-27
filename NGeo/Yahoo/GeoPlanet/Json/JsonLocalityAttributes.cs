using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [DataContract]
    internal class JsonLocalityAttributes
    {
        [DataMember(Name = "type")]
        internal string Type { get; set; }
    }
}

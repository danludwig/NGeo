using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [DataContract]
    internal class JsonAdminAttributes
    {
        [DataMember(Name = "code")]
        internal string Code { get; set; }

        [DataMember(Name = "type")]
        internal string Type { get; set; }
    }
}

using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public enum RequestView
    {
        [EnumMember(Value = "short")]
        Short = 0,

        [EnumMember(Value = "long")]
        Long = 1,
    }
}

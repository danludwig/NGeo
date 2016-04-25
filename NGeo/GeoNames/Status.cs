using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class Status
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; }
    }
}
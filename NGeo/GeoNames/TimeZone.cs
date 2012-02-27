using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class TimeZone
    {
        [DataMember(Name = "timeZoneId")]
        public string Id { get; internal set; }

        [DataMember(Name = "dstOffset")]
        public double DstOffset { get; internal set; }

        [DataMember(Name = "gmtOffset")]
        public double GmtOffset { get; internal set; }

        public override string ToString()
        {
            return Id;
        }
    }
}

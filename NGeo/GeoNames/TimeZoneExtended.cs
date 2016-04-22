using System;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class TimeZoneExtended
    {
        [DataMember(Name = "timezoneId")]
        public string Id { get; internal set; }

        [DataMember(Name = "dstOffset")]
        public double DstOffset { get; internal set; }

        [DataMember(Name = "gmtOffset")]
        public double GmtOffset { get; internal set; }

        [DataMember(Name = "rawOffset")]
        public double RawOffset { get; internal set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; internal set; }

        [DataMember(Name = "countryName")]
        public string CountryName { get; internal set; }

        [DataMember(Name = "lat")]
        public double Latitude { get; internal set; }

        [DataMember(Name = "lng")]
        public double Longitude { get; internal set; }

        // Kevin Hollingshead (kh14821@gmail.com)
        // DateTimes aren't working, giving an error that reflects that the
        // JSON deserializer is expecting an obsolete format ("/Date = .../")
        // and I'm not sure how to fix it right now. Ping me if you need these
        // and I'll try to help find a solution.

        //[DataMember(Name = "time")]
        //public DateTime Time { get; internal set; }

        //[DataMember(Name = "sunrise")]
        //public DateTime Sunrise { get; internal set; }

        //[DataMember(Name = "sunset")]
        //public DateTime Sunset { get; internal set; }

        public override string ToString()
        {
            return Id;
        }
    }
}

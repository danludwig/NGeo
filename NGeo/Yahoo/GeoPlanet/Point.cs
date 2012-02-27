using System.Globalization;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class Point
    {
        [DataMember(Name = "latitude")]
        public double Latitude { get; internal set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; internal set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0},{1}", Latitude, Longitude);
        }
    }
}

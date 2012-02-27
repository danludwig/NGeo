using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class BoundingBox
    {
        [DataMember(Name = "southWest")]
        public Point Southwest { get; internal set; }

        [DataMember(Name = "northEast")]
        public Point Northeast { get; internal set; }
    }
}

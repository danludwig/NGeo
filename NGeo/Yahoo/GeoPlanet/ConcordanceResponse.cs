using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class ConcordanceResponse
    {
        public ConcordanceNamespace ForNamespace { get; internal set; }

        [DataMember(Name = "woeid")]
        public int WoeId { get; internal set; }

        [DataMember(Name = "geonames")]
        public int GeoNameId { get; internal set; }

        [DataMember(Name = "iso")]
        public string Iso { get; internal set; }

        [DataMember(Name = "fips10")]
        public string Fips10 { get; internal set; }

        [DataMember(Name = "osm")]
        public int OpenStreetMapId { get; internal set; }

        [DataMember(Name = "wiki")]
        public int WikipediaPageId { get; internal set; }

        [DataMember(Name = "cctld")]
        public string IanaTld { get; internal set; }

    }
}

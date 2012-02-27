using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Bounding box data returned by the PlaceFinder service. See 
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html">official documentation</see>.
    /// </summary>
    [DataContract]
    public class BoundingBox
    {
        /// <summary>
        /// North latitude in degrees. Range is -90.0 to 90.0
        /// </summary>
        [DataMember(Name = "north")]
        public double North { get; set; }

        /// <summary>
        /// South latitude in degrees. Range is -90.0 to 90.0
        /// </summary>
        [DataMember(Name = "south")]
        public double South { get; set; }

        /// <summary>
        /// East longitude in degrees. Range is -180.0 to 180.0
        /// </summary>
        [DataMember(Name = "east")]
        public double East { get; set; }

        /// <summary>
        /// West longitude in degrees. Range is -180.0 to 180.0
        /// </summary>
        [DataMember(Name = "west")]
        public double West { get; set; }

    }
}

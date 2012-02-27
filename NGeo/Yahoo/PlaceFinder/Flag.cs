using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Flags for a Yahoo! PlaceFinder request. See 
    /// <seealso cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#flags-parameter">official 
    /// documentation</seealso> for more information.
    /// </summary>
    [DataContract]
    internal enum Flag
    {
        /// <summary>
        /// Only return coordinate data and match quality elements; do not return address data elements.
        /// </summary>
        [EnumMember(Value = "C")]
        CoordinateDataOnly = 0,

        /// <summary>
        /// Do not return woeid element. This impacts the radius output.
        /// </summary>
        [EnumMember(Value = "E")]
        NoWoeId = 1,

        /// <summary>
        /// Return global area elements instead of US-specific elements.
        /// </summary>
        [EnumMember(Value = "G")]
        Global = 2,

        /// <summary>
        /// Return data in JSON format. Default format is XML.
        /// </summary>
        [EnumMember(Value = "J")]
        Json = 3,

        /// <summary>
        /// Return data in Serialized PHP format. Default format is XML.
        /// </summary>
        [EnumMember(Value = "P")]
        Php = 4,

        /// <summary>
        /// Return nearest commercial airport code element for each result.
        /// </summary>
        [EnumMember(Value = "Q")]
        Airport = 5,

        /// <summary>
        /// Return telephone area code element for each result.
        /// </summary>
        [EnumMember(Value = "R")]
        TelephoneAreaCode = 6,

        /// <summary>
        /// Return detailed street attributes (Prefix, Body, Suffix, etc).
        /// </summary>
        [EnumMember(Value = "S")]
        StreetDetail = 7,

        /// <summary>
        /// Return timezone information element for each result.
        /// </summary>
        [EnumMember(Value = "T")]
        TimeZone = 8,

        /// <summary>
        /// Return bounding box element for each area result.
        /// </summary>
        [EnumMember(Value = "X")]
        BoundingBox = 9,

    }
}

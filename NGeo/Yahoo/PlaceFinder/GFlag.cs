using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// GFlags for a Yahoo! PlaceFinder request. See 
    /// <seealso cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#gflags-parameter">official 
    /// documentation</seealso> for more information.
    /// </summary>
    [DataContract]
    internal enum GFlag
    {
        /// <summary>
        /// Return neighborhood names for each result.
        /// </summary>
        [EnumMember(Value = "A")]
        Neighborhoods = 0,

        /// <summary>
        /// Look up cross streets for each result.
        /// </summary>
        [EnumMember(Value = "C")]
        CrossStreets = 1,

        /// <summary>
        /// Limit results to the locale country.
        /// </summary>
        [EnumMember(Value = "L")]
        LimitToLocaleCountry = 2,

        /// <summary>
        /// Quick mode, enable exact matches only for free-form input.
        /// </summary>
        [EnumMember(Value = "Q")]
        QuickMode = 3,

        /// <summary>
        /// Reverse geocode coordinates for each result. To perform reverse geocoding, specify the 
        /// latitude and longitude in the location parameter. The response will include information 
        /// such as the street address.
        /// </summary>
        [EnumMember(Value = "R")]
        Reverse = 4,

    }
}

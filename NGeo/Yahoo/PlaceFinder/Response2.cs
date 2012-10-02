using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Response returned by the PlaceFinder service. See
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html">official documentation</see>.
    /// </summary>
    [DataContract]
    public class Response2
    {
        /// <summary>
        /// Top-level element for the response.
        /// Container for the remaining elements in this table.
        /// More than one result element may be returned if the given address is ambiguous.
        /// </summary>
        [DataMember(Name = "ResultSet")]
        internal ResultSet2 ResultSet { get; set; }
    }
}

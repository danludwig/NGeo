using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Response returned by the PlaceFinder service. See
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html">official documentation</see>.
    /// </summary>
    [DataContract]
    public class Response
    {
        /// <summary>
        /// Top-level element for the response.
        /// Container for the remaining elements in this table.
        /// More than one result element may be returned if the given address is ambiguous.
        /// </summary>
        [DataMember(Name = "ResultSet")]
        internal ResultSet ResultSet { get; set; }

        internal Response() { }

        internal Response(Response2 response2)
        {
            ResultSet = new ResultSet
            {
                ErrorCode = response2.ResultSet.ErrorCode,
                ErrorMessage = response2.ResultSet.ErrorMessage,
                Found = response2.ResultSet.Found,
                Locale = response2.ResultSet.Locale,
                Quality = response2.ResultSet.Quality,
                Results = new ReadOnlyCollection<Result>(response2.ResultSet.Result ?? new List<Result>()),
            };
        }
    }
}

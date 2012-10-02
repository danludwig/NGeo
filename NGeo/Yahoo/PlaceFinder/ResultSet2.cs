using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Response data returned by the PlaceFinder service. See
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html">official documentation</see>.
    /// </summary>
    [DataContract]
    internal class ResultSet2 : IEnumerable<Result>
    {
        /// <summary>
        /// Error code.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#error-codes">Error Codes</see> for possible values.
        /// </summary>
        [DataMember(Name = "Error")]
        internal int ErrorCode { get; set; }

        /// <summary>
        /// Error message (locale specific).
        /// </summary>
        [DataMember(Name = "ErrorMessage")]
        internal string ErrorMessage { get; set; }

        /// <summary>
        /// Number of Result elements.
        /// </summary>
        [DataMember(Name = "Found")]
        internal int Found { get; set; }

        /// <summary>
        /// The language and country.
        /// A two-letter ISO-639 major language code
        /// and a two-letter ISO-3166-1 alpha-2 country code,
        /// separated by either a hyphen or underscore.
        /// </summary>
        [DataMember(Name = "Locale")]
        internal string Locale { get; set; }

        /// <summary>
        /// Best possible quality of the location parameter (input address).
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#address-quality">Address Quality</see> for details.
        /// </summary>
        [DataMember(Name = "Quality")]
        internal int Quality { get; set; }

        /// <summary>
        /// Contains elements associated with a single match result.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#result-elements">Result Sub-elements</see>.
        /// </summary>
        [DataMember(Name = "Result")]
        internal List<Result> Result
        {
            get { return _result; }
            set
            {
                _result = value;
                Results = new ReadOnlyCollection<Result>(value);
            }
        }
        private List<Result> _result;

        internal ReadOnlyCollection<Result> Results { get; private set; }

        public IEnumerator<Result> GetEnumerator()
        {
            return Results.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}, {1}: {2} of {3}",
                Locale, ErrorMessage, Results.Count, Found);
        }

    }
}

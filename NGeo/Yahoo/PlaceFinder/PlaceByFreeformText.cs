using System;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new free form Yahoo! PlaceFinder request. In this format, all address components
    /// are combined in a single parameter: location. When necessary, use commas to separate the components.
    /// A free-form format may be one  of the formats shown in the
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#free-form-format">official
    /// documentation table</see>. Each of these formats may be followed by an optional country name or code.
    /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#free-form-format">the
    /// official documentation</see> for more information.
    /// </summary>
    public class PlaceByFreeformText : PlaceBy
    {
        /// <summary>
        /// Create a new free form Yahoo! PlaceFinder request. In this format, all address components
        /// are combined in a single parameter: location. When necessary, use commas to separate the components.
        /// A free-form format may be one  of the formats shown in the
        /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#free-form-format">official
        /// documentation table</see>. Each of these formats may be followed by an optional country name or code.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#free-form-format">the
        /// official documentation</see> for more information.
        /// </summary>
        /// <param name="freeformTextLocation">
        /// A geographical location.
        /// For example,  <example>"701 First Ave., Sunnyvale, CA 94089"</example>
        /// </param>
        public PlaceByFreeformText(string freeformTextLocation)
        {
            Location = freeformTextLocation;
        }

        private string _location;

        /// <summary>
        /// A geographical location.
        /// For example, <example>"701 First Ave., Sunnyvale, CA 94089"</example>
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#free-form-format">the
        /// official documentation</see> for more information.
        /// </summary>
        public string Location
        {
            get { return _location; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Location cannot be null or whitespace.", "value");
                _location = value;
            }
        }
    }
}

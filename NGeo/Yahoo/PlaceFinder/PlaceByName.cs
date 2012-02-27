using System;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new Yahoo! PlaceFinder request for a named place.
    /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#location-parameters">the 
    /// official documentation</see> for more information.
    /// </summary>
    public class PlaceByName : PlaceBy
    {
        /// <summary>
        /// Create a new Yahoo! PlaceFinder request for a named place.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#location-parameters">the 
        /// official documentation</see> for more information.
        /// </summary>
        /// <param name="name">
        /// A Place of Interest (POI) name, Area of Interest (AOI) name, or 
        /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#airport-codes">airport 
        /// code</see>. See also <seealso cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#poi-aoi-names">POI 
        /// and AOI Names</seealso>. 
        /// For example, <example>"Yosemite National Park"</example>
        /// </param>
        public PlaceByName(string name)
        {
            Name = name;
        }

        private string _name;

        /// <summary>
        /// A Place of Interest (POI) name, Area of Interest (AOI) name, or 
        /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#airport-codes">airport 
        /// code</see>. See also <seealso cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#poi-aoi-names">POI 
        /// and AOI Names</seealso>. 
        /// For example, <example>"Yosemite National Park"</example>
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or whitespace.", "value");
                _name = value;
            }
        }
    }
}

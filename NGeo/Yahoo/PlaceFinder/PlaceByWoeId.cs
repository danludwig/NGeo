using System;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new Yahoo! PlaceFinder request for a Where On Earth (WOE) ID.
    /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#location-parameters">the
    /// official documentation</see> for more information.
    /// </summary>
    public class PlaceByWoeId : PlaceBy
    {
        /// <summary>
        /// Create a new Yahoo! PlaceFinder request for a Where On Earth (WOE) ID.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#location-parameters">the
        /// official documentation</see> for more information.
        /// </summary>
        /// <param name="woeId">
        /// <see cref="http://developer.yahoo.com/geo/geoplanet/guide/concepts.html#woeids">Where
        /// On Earth ID</see>. Must be an integer. Ignored if location or name parameter is provided.
        /// For example, <example>12797150</example>
        /// </param>
        public PlaceByWoeId(int woeId)
        {
            WoeId = woeId;
        }

        private int _woeId;

        /// <summary>
        /// <see cref="http://developer.yahoo.com/geo/geoplanet/guide/concepts.html#woeids">Where
        /// On Earth ID</see>. Must be an integer. Ignored if location or name parameter is provided.
        /// For example, <example>12797150</example>
        /// </summary>
        public int WoeId
        {
            get { return _woeId; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("WoeId must be greater than zero.", "value");
                _woeId = value;
            }
        }
    }
}

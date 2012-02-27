using System;
using System.Globalization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new Yahoo! PlaceFinder request for latitude &amp; longitude coordinates.
    /// </summary>
    public class PlaceByCoordinates : PlaceBy
    {
        /// <summary>
        /// Create a new Yahoo! PlaceFinder request for latitude and longitude coordinates.
        /// </summary>
        /// <param name="latitude">
        /// The latitude coordinate. For example, <example>37.775391</example>
        /// </param>
        /// <param name="longitude">
        /// The longitude coordinate. For example, <example>122.412209</example>
        /// </param>
        public PlaceByCoordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        private double _latitude;

        /// <summary>
        /// The latitude coordinate. For example, <example>37.775391</example>
        /// </summary>
        public double Latitude
        {
            get { return _latitude; }
            set
            {
                if (value > 90 || value < -90)
                    throw new ArgumentException("Latitude must be between -90.0 and 90.0.");
                _latitude = value;
            }
        }

        private double _longitude;

        /// <summary>
        /// The longitude coordinate. For example, <example>122.412209</example>
        /// </summary>
        public double Longitude
        {
            get { return _longitude; }
            set
            {
                if (value > 180 || value < -180)
                    throw new ArgumentException("Longitude must be between -180.0 and 180.0.");
                _longitude = value;
            }
        }

        /// <summary>
        /// String representation of latitude and longitude coordinates.
        /// </summary>
        public string Location
        {
            get { return string.Format(CultureInfo.InvariantCulture, "{0} {1}", Latitude, Longitude); }
        }

    }
}

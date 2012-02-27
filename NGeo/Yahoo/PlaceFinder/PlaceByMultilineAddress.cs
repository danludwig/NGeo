using System;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new Yahoo! PlaceFinder request for a multi-line address.
    /// Multi-line addresses use two or three lines to represent an address. 
    /// These are specified with the following location parameters: line1, line2, and line3. 
    /// Typically, line1 contains a house number and street name, and optionally a cross street name; 
    /// line2 contains City, State, and Postal code; line3 contains additional address data needed in 
    /// certain countries. With multi-line addresses, delimiters are not necessary between address lines.
    /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#multi-line-format">the 
    /// official documentation</see> for more information.
    /// </summary>
    public class PlaceByMultilineAddress : PlaceBy
    {
        /// <summary>
        /// Create a new Yahoo! PlaceFinder request for a multi-line address.
        /// Multi-line addresses use two or three lines to represent an address. 
        /// These are specified with the following location parameters: line1, line2, and line3. 
        /// Typically, line1 contains a house number and street name, and optionally a cross street name; 
        /// line2 contains City, State, and Postal code; line3 contains additional address data needed in 
        /// certain countries. With multi-line addresses, delimiters are not necessary between address lines.
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#multi-line-format">the 
        /// official documentation</see> for more information.
        /// </summary>
        /// <param name="line1">
        /// First line of address (street address or intersection). 
        /// For example, <example>"701 First Ave."</example>
        /// </param>
        /// <param name="line2">
        /// First line of address (street address or intersection). 
        /// For example, <example>"701 First Ave."</example>
        /// </param>
        /// <param name="line3">
        /// Third line of address (postal code in UK). 
        /// For example, <example>"EC1A 1BB"</example>
        /// </param>
        public PlaceByMultilineAddress(string line1, string line2 = null, string line3 = null)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
        }

        private string _line1;

        /// <summary>
        /// First line of address (street address or intersection).,
        /// For example <example>"701 First Ave."</example>
        /// </summary>
        public string Line1
        {
            get { return _line1; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Line1 cannot be null or whitespace.", "value");
                _line1 = value;
            }
        }

        /// <summary>
        /// Second line of address (city-state-zip in US).
        /// For example, <example>"Sunnyvale, CA 94089"</example>
        /// </summary>
        public string Line2 { get; set; }

        /// <summary>
        /// Third line of address (postal code in UK).
        /// For example, <example>"EC1A 1BB"</example>
        /// </summary>
        public string Line3 { get; set; }

    }
}

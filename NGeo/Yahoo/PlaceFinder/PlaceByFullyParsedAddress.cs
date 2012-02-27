namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// A new Yahoo! PlaceFinder request for a fully-parsed address.
    /// In a fully-parsed address, each address component is specified in a separate location parameter. 
    /// The parameters that support fully-parsed addresses are listed in the "Address Format" column in 
    /// the table under <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#location-parameters">Location 
    /// Parameters</see>. No delimiters are needed to separate the address components.
    /// For best results, provide level0 (country), level1 (state/province), level2 (county), and level3 (city). 
    /// Providing level3 without level1 or level0 might produce erroneous results.
    /// </summary>
    public class PlaceByFullyParsedAddress : PlaceBy
    {
        /// <summary>
        /// House number. For example, <example>"701"</example>
        /// </summary>
        public string House { get; set; }

        /// <summary>
        /// Street name. For example, <example>"First Ave."</example>
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Unit type, such as apartment (Apt) or suite (Ste).
        /// For example, <example>"Apt"</example>
        /// </summary>
        public string UnitType { get; set; }

        /// <summary>
        /// Unit/Suite/Apartment/Box. For example, <example>"324"</example>
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Cross Street name. For example, <example>"Mathilda Ave."</example>
        /// </summary>
        public string CrossStreet { get; set; }

        /// <summary>
        /// Postal code. For example, <example>"94089"</example>
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Level 4 Administrative name (Neighborhood).
        /// For example, <example>"SOMA"</example>
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// Level 3 Administrative name (City/Town/Locality). 
        /// Do not specify level3 unless level1 or level0 is also specified; otherwise, 
        /// erroneous results might be returned. For best results, specify at least level0 through level3.
        /// For example, <example>"Sunnyvale"</example>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Level 2 Administrative name (County). For example, <example>"Santa Clara"</example>
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Level 1 Administrative name (State/Province) or abbreviation (US only).
        /// For example, <example>"CA"</example>
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Level 0 Administrative name (Country) or country code.
        /// For example, <example>"USA"</example> 
        /// </summary>
        public string Country { get; set; }
    }
}

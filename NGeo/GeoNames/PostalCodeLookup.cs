namespace NGeo.GeoNames
{
    /// <summary>
    /// Encapsulates arguments sent to the PostalCodeLookup service.
    /// </summary>
    public class PostalCodeLookup
    {
        /// <summary>
        /// Default property values are: MaxRows = 20, Style = ResultStyle.Medium.
        /// </summary>
        public PostalCodeLookup()
        {
            MaxRows = 20;
            Style = ResultStyle.Medium;
        }

        /// <summary>
        /// Find place names in this postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Find place names in this country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Find place names in this radius.
        /// </summary>
        public double RadiusInKm { get; set; }

        /// <summary>
        /// GeoNames services require a user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Don't return any more than this number of results. Default value is 100.
        /// </summary>
        public int MaxRows { get; set; }

        /// <summary>
        /// Amount of detail returned by the GeoNames service. Default value is Full.
        /// </summary>
        public ResultStyle Style { get; set; }
    }
}

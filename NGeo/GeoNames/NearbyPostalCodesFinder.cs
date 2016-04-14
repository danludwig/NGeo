
namespace NGeo.GeoNames
{
    /// <summary>
    /// Encapsulates arguments sent to the FindNearbyPostalCodes service.
    /// There are two variants:
    /// 1. Lat/Lon - Returns postal codes nearby this point.
    /// 2. Postal Code/Country - Returns postal codes nearby this postal code.
    /// </summary>
    public class NearbyPostalCodesFinder
    {
        /// <summary>
        /// Default property values are: Language = "local", MaxRows = 100, Style = ResultStyle.Medium.
        /// </summary>
        public NearbyPostalCodesFinder()
        {
            Language = "local";
            MaxRows = 100;
            Style = ResultStyle.Medium;
        }

        /// <summary>
        /// Find postal codes near this latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Find postal codes near this longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// GeoNames services require a user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Find postal codes near this postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country for the postal code parameter when the postal code/country/radius 
        /// variant is used.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// In border areas this parameter will restrict the search on the local 
        /// country.
        /// </summary>
        public string LocalCountry { get; set; }

        /// <summary>
        /// Find postal codes within this radius of the latitude and longitude.
        /// Note: The Local Country parameter is not (yet) supported.
        /// </summary>
        public double RadiusInKm { get; set; }

        /// <summary>
        /// Language of returned 'name' element (the pseudo language code 'local' will 
        /// return it in local language).
        /// Default value is 'local'.
        /// </summary>
        public string Language { get; set; }

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

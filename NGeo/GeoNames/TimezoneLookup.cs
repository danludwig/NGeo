
namespace NGeo.GeoNames
{
    /// <summary>
    /// Encapsulates arguments sent to the Timezone service.
    /// </summary>
    public class TimeZoneLookup
    {
        /// <summary>
        /// Default property values are: Language = "local".
        /// </summary>
        public TimeZoneLookup()
        {
            Language = "local";
        }

        /// <summary>
        /// Get the timezone using this latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Get the timezone using this longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Get the timezone using this radius of the latitude and longitude.
        /// </summary>
        public double RadiusInKm { get; set; }

        /// <summary>
        /// GeoNames services require a user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Language of returned 'country' element (the pseudo language code 'local' will 
        /// return it in local language).
        /// Default value is 'local'.
        /// </summary>
        public string Language { get; set; }
    }
}

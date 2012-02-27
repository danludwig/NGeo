
namespace NGeo.GeoNames
{
    /// <summary>
    /// Encapsulates arguments sent to the FindNearbyPlaceNames service.
    /// </summary>
    public class NearbyPlaceNameFinder
    {
        /// <summary>
        /// Default property values are: Language = "local", MaxResults = 100, Style = ResultStyle.Full.
        /// </summary>
        public NearbyPlaceNameFinder()
        {
            Language = "local";
            MaxRows = 100;
            Style = ResultStyle.Medium;
        }

        /// <summary>
        /// Find place names near this latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Find place names near this longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// GeoNames services require a user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Language of returned 'name' element (the pseudo language code 'local' will return it in local language). 
        /// Default value is 'local'.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Find place names within this radius of the latitude and longitude.
        /// </summary>
        public double? RadiusInKm { get; set; }

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

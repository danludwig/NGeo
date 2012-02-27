using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    /// <summary>
    /// Data returned by the PlaceFinder service. See 
    /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html">official documentation</see>.
    /// </summary>
    [DataContract]
    public class Result
    {
        /// <summary>
        /// Quality of the result. Returned if P flag is not set. See 
        /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#address-quality">Address 
        /// Quality</see> for details.
        /// </summary>
        [DataMember(Name = "quality")]
        public int Quality { get; internal set; }

        /// <summary>
        /// Latitude of matched point in degrees, should be on a road center-line. 
        /// Returned if Php flag is not set.
        /// </summary>
        [DataMember(Name = "latitude")]
        public double Latitude { get; internal set; }

        /// <summary>
        /// Longitude of matched point in degrees, should be on a road center-line. 
        /// Returned if Php flag is not set.
        /// </summary>
        [DataMember(Name = "longitude")]
        public double Longitude { get; internal set; }

        /// <summary>
        /// Latitude of offset point in degrees, representing building/parcel setback from road center-line. 
        /// Returned if Php flag is not set and if Offset is greater than 0.
        /// </summary>
        [DataMember(Name = "offsetlat")]
        public double? OffsetLatitude { get; internal set; }

        /// <summary>
        /// Longitude of offset point in degrees, representing building/parcel setback from road center-line. 
        /// Returned if Php flag is not set and if Offset is greater than 0.
        /// </summary>
        [DataMember(Name = "offsetlon")]
        public double? OffsetLongitude { get; internal set; }

        /// <summary>
        /// Radius of matched area in meters. 
        /// Returned if Php flag is not set. 
        /// Default if NoWoeId flag is set, dynamic if not.
        /// </summary>
        [DataMember(Name = "radius")]
        public int RadiusInMeters { get; internal set; }

        /// <summary>
        /// Defines the extent of a box that encloses an area. 
        /// Returned if Php flag is not set and BoundingBox flag is set. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#bounding-box-element">Bounding 
        /// Box Sub-elements</see> for details.
        /// </summary>
        [DataMember(Name = "boundingbox")]
        public BoundingBox BoundingBox { get; internal set; }

        /// <summary>
        /// Point of Interest name / Area of Interest name or Airport code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; internal set; }

        /// <summary>
        /// First line of address (House Street UnitType Unit). 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "line1")]
        public string Line1 { get; internal set; }

        /// <summary>
        /// Second line of address (City State Zip in the US). 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "line2")]
        public string Line2 { get; internal set; }

        /// <summary>
        /// Third line of address. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "line3")]
        public string Line3 { get; internal set; }

        /// <summary>
        /// Fourth line of address. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "line4")]
        public string Line4 { get; internal set; }

        /// <summary>
        /// Cross streets nearest to location. 
        /// Returned if CoordinateDataOnly flag is not set and CrossStreets gflag is set.
        /// </summary>
        [DataMember(Name = "cross")]
        public string CrossStreets { get; internal set; }

        /// <summary>
        /// House number. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "house")]
        public string HouseNumber { get; internal set; }

        /// <summary>
        /// Street name or container for detailed street data (if StreetDetail flag is set). 
        /// Returned if CoordinateDataOnly flag is not set. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#street-elements">Street Sub-elements</see>.
        /// </summary>
        [DataMember(Name = "street")]
        public string Street { get; internal set; }

        /// <summary>
        /// Cross street name or container for detailed street data (if StreetDetail flag is set). 
        /// Returned if CoordinateDataOnly flag is not set. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#xstreet-elements">XStreet Sub-elements</see>.
        /// </summary>
        [DataMember(Name = "xstreet")]
        public string CrossStreet { get; internal set; }

        /// <summary>
        /// Unit type. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "unittype")]
        public string UnitType { get; internal set; }

        /// <summary>
        /// Unit/Suite/Apartment/Box. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "unit")]
        public string Unit { get; internal set; }

        /// <summary>
        /// Postal code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "postal")]
        public string Postal { get; internal set; }

        /// <summary>
        /// Unique zip code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "uzip")]
        public string UniqueZipCode { get; internal set; }

        /// <summary>
        /// Neighborhood name. 
        /// Returned if CoordinateDataOnly flag is not set and Global flag is not set. 
        /// See <see cref="http://developer.yahoo.com/geo/placefinder/guide/responses.html#neighborhood-element">Neighborhood Element</see> for details.
        /// </summary>
        [DataMember(Name = "neighborhood")]
        public string Neighborhood { get; internal set; }

        /// <summary>
        /// City name. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is not set.
        /// </summary>
        [DataMember(Name = "city")]
        public string CityName { get; internal set; }

        /// <summary>
        /// County name (US/Canada only). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is not set.
        /// </summary>
        [DataMember(Name = "county")]
        public string CountyName { get; internal set; }

        /// <summary>
        /// County ISO 3166-2 code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "countycode")]
        public string CountyCode { get; internal set; }

        /// <summary>
        /// State / Province name. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is not set.
        /// </summary>
        [DataMember(Name = "state")]
        public string StateName { get; internal set; }

        /// <summary>
        /// State ISO 3166-2 code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "statecode")]
        public string StateCode { get; internal set; }

        /// <summary>
        /// Country name. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is not set.
        /// </summary>
        [DataMember(Name = "country")]
        public string CountryName { get; internal set; }

        /// <summary>
        /// Country ISO 3166-1 code. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "countrycode")]
        public string CountryCode { get; internal set; }

        /// <summary>
        /// Level 4 area name (neighborhood). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level4")]
        public string Level4Name { get; internal set; }

        /// <summary>
        /// Level 3 area name (city / town / locality). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level3")]
        public string Level3Name { get; internal set; }

        /// <summary>
        /// Level 2 area name (county). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level2")]
        public string Level2Name { get; internal set; }

        /// <summary>
        /// Level 2 area ISO 3166-2 code. 
        /// Returned if CoordinateDataOnly flag is not set and Global flag is set.
        /// </summary>
        [DataMember(Name = "level2code")]
        public string Level2Code { get; internal set; }

        /// <summary>
        /// Level 1 area name (state / province). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level1")]
        public string Level1Name { get; internal set; }

        /// <summary>
        /// Level 1 area ISO 3166-2 code. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level1code")]
        public string Level1Code { get; internal set; }

        /// <summary>
        /// Level 0 area name (country). 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level0")]
        public string Level0Name { get; internal set; }

        /// <summary>
        /// Level 0 area ISO 3166-1 code. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and Global flag is set.
        /// </summary>
        [DataMember(Name = "level0code")]
        public string Level0Code { get; internal set; }

        /// <summary>
        /// Timezone tz name. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and TimeZone flag is set.
        /// </summary>
        [DataMember(Name = "timezone")]
        public string TimeZone { get; internal set; }

        /// <summary>
        /// Nearest commercial 
        /// <see cref="http://developer.yahoo.com/geo/placefinder/guide/requests.html#airport-codes">airport 
        /// code</see> element for result.
        /// Returned if Airport flag is set.
        /// </summary>
        [DataMember(Name = "airport")]
        public string AirportCode { get; internal set; }

        /// <summary>
        /// Telephone area code. 
        /// Returned if CoordinateDataOnly flag is not set 
        /// and TelephoneAreaCode flag is set.
        /// </summary>
        [DataMember(Name = "areacode")]
        public string AreaCode { get; internal set; }

        /// <summary>
        /// <see cref="http://developer.yahoo.com/geo/geoplanet/guide/concepts.html#woeids">Where 
        /// On Earth ID</see> for area. 
        /// Returned if CoordinateDataOnly flag is not set.
        /// </summary>
        [DataMember(Name = "woeid")]
        internal string WoeIdInternal { get; set; }
        public int? WoeId
        {
            get
            {
                int woeId;
                if (int.TryParse(WoeIdInternal, out woeId))
                    return woeId;
                return null;
            }
        }

        /// <summary>
        /// Where On Earth <see cref="http://developer.yahoo.com/geo/geoplanet/guide/concepts.html#placetypes">place 
        /// type</see> for area. Returned if C flag is not set.
        /// </summary>
        [DataMember(Name = "woetype")]
        internal string WoeTypeInternal { get; set; }
        public int? WoeType
        {
            get
            {
                int woeType;
                if (int.TryParse(WoeTypeInternal, out woeType))
                    return woeType;
                return null;
            }
        }

        /// <summary>
        /// A unique string derived from the returned address. 
        /// Can be used by an app to index content based on the address.
        /// </summary>
        [DataMember(Name = "hash")]
        public string Hash { get; internal set; }

    }
}

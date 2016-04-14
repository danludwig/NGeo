using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class NearbyPostalCode
    {
        [DataMember(Name = "postalCode")]
        public string Value { get; internal set; }

        [DataMember(Name = "placeName")]
        public string Name { get; internal set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; internal set; }

        [DataMember(Name = "lat")]
        public double Latitude { get; internal set; }

        [DataMember(Name = "lng")]
        public double Longitude { get; internal set; }

        [DataMember(Name = "distance")]
        public double Distance { get; set; }

        [DataMember(Name = "adminCode1")]
        public string Admin1Code { get; internal set; }

        [DataMember(Name = "adminName1")]
        public string Admin1Name
        {
            get { return _admin1Name; }
            internal set { _admin1Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin1Name;

        [DataMember(Name = "adminCode2")]
        public string Admin2Code { get; internal set; }

        [DataMember(Name = "adminName2")]
        public string Admin2Name
        {
            get { return _admin2Name; }
            internal set { _admin2Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin2Name;

        [DataMember(Name = "adminCode3")]
        public string Admin3Code { get; set; }

        [DataMember(Name = "adminName3")]
        public string Admin3Name
        {
            get { return _admin3Name; }
            internal set { _admin3Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin3Name;

        public override string ToString()
        {
            return Name;
        }
    }
}

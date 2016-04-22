using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class NearbyPostalCode
    {
        [DataMember(Name = "postalCode")]
        public string Value 
        {
            get { return _value; }
            internal set { _value = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _value;

        [DataMember(Name = "placeName")]
        public string Name
        {
            get { return _name; }
            internal set { _name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _name;

        [DataMember(Name = "countryCode")]
        public string CountryCode
        {
            get { return _countryCode; }
            internal set { _countryCode = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _countryCode;

        [DataMember(Name = "lat")]
        public double Latitude { get; internal set; }

        [DataMember(Name = "lng")]
        public double Longitude { get; internal set; }

        [DataMember(Name = "distance")]
        public double Distance { get; set; }

        [DataMember(Name = "adminCode1")]
        public string Admin1Code
        {
            get { return _admin1Code; }
            internal set { _admin1Code = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin1Code;

        [DataMember(Name = "adminName1")]
        public string Admin1Name
        {
            get { return _admin1Name; }
            internal set { _admin1Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin1Name;

        [DataMember(Name = "adminCode2")]
        public string Admin2Code
        {
            get { return _admin2Code; }
            internal set { _admin2Code = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin2Code;

        [DataMember(Name = "adminName2")]
        public string Admin2Name
        {
            get { return _admin2Name; }
            internal set { _admin2Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin2Name;

        [DataMember(Name = "adminCode3")]
        public string Admin3Code
        {
            get { return _admin3Code; }
            internal set { _admin3Code = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin3Code;

        [DataMember(Name = "adminName3")]
        public string Admin3Name
        {
            get { return _admin3Name; }
            internal set { _admin3Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin3Name;

        public override string ToString()
        {
            return Value;
        }
    }
}

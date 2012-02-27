using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class Toponym
    {
        [DataMember(Name = "geonameId")]
        public int GeoNameId { get; internal set; }

        [DataMember(Name = "lat")]
        public double Latitude { get; internal set; }

        [DataMember(Name = "lng")]
        public double Longitude { get; internal set; }

        [DataMember(Name = "name")]
        public string Name { get; internal set; }

        [DataMember(Name = "toponymName")]
        public string ToponymName { get; internal set; }

        [DataMember(Name = "alternateNames")]
        internal List<AlternateName> AlternateNamesList
        {
            get { return _alternateNamesList; }
            set
            {
                _alternateNamesList = value;
                AlternateNames = new ReadOnlyCollection<AlternateName>(value);
            }
        }
        private List<AlternateName> _alternateNamesList;

        public ReadOnlyCollection<AlternateName> AlternateNames { get; private set; }

        [DataMember(Name = "numberOfChildren")]
        public int? ChildCount { get; internal set; }

        [DataMember(Name = "fcl")]
        public string FeatureClassCode { get; internal set; }

        [DataMember(Name = "fclName")]
        public string FeatureClassName { get; internal set; }

        [DataMember(Name = "fcode")]
        public string FeatureCode { get; internal set; }

        [DataMember(Name = "fcodeName")]
        public string FeatureName { get; internal set; }

        [DataMember(Name = "continentCode")]
        public string ContinentCode { get; internal set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; internal set; }

        [DataMember(Name = "countryName")]
        public string CountryName
        {
            get { return _countryName; }
            internal set { _countryName = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _countryName;

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

        [DataMember(Name = "adminCode4")]
        public string Admin4Code { get; internal set; }

        [DataMember(Name = "adminName4")]
        public string Admin4Name
        {
            get { return _admin4Name; }
            internal set { _admin4Name = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _admin4Name;

        [DataMember(Name = "timezone")]
        public TimeZone TimeZone { get; internal set; }

        [DataMember(Name = "population")]
        public long? Population { get; internal set; }

        [DataMember(Name = "elevation")]
        public int? Elevation { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

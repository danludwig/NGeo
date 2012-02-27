using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class Country
    {
        [DataMember(Name = "geonameId")]
        public int GeoNameId { get; internal set; }

        [DataMember(Name = "continent")]
        public string ContinentCode { get; internal set; }

        [DataMember(Name = "continentName")]
        public string ContinentName { get; internal set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; internal set; }

        [DataMember(Name = "countryName")]
        public string CountryName { get; internal set; }

        [DataMember(Name = "isoNumeric")]
        public int? IsoNumericCode { get; internal set; }

        [DataMember(Name = "isoAlpha3")]
        public string IsoAlpha3Code { get; internal set; }

        [DataMember(Name = "fipsCode")]
        public string FipsCode
        {
            get { return _fipsCode; }
            internal set { _fipsCode = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _fipsCode;

        [DataMember(Name = "capital")]
        public string CapitalCityName
        {
            get { return _capitalCityName; }
            internal set { _capitalCityName = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _capitalCityName;

        [DataMember(Name = "population")]
        public long Population { get; internal set; }

        private string _areaInSqKm;

        [DataMember(Name = "areaInSqKm")]
        public string AreaInSqKm
        {
            get { return _areaInSqKm; }
            internal set { _areaInSqKm = value.ToNullIfEmptyOrWhiteSpace(); }
        }

        [DataMember(Name = "currencyCode")]
        public string CurrencyCode
        {
            get { return _currencyCode; }
            internal set { _currencyCode = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _currencyCode;

        [DataMember(Name = "languages")]
        public string Languages
        {
            get { return _languages; }
            internal set { _languages = value.ToNullIfEmptyOrWhiteSpace(); }
        }
        private string _languages;

        [DataMember(Name = "bBoxWest")]
        public double? BoundingBoxWest { get; internal set; }

        [DataMember(Name = "bBoxNorth")]
        public double? BoundingBoxNorth { get; internal set; }

        [DataMember(Name = "bBoxEast")]
        public double? BoundingBoxEast { get; internal set; }

        [DataMember(Name = "bBoxSouth")]
        public double? BoundingBoxSouth { get; internal set; }

        public override string ToString()
        {
            return CountryName;
        }

    }
}

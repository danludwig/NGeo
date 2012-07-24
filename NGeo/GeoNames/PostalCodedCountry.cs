using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class PostalCodedCountry
    {
        [DataMember(Name = "countryCode")]
        public string CountryCode { get; internal set; }

        [DataMember(Name = "countryName")]
        public string CountryName { get; internal set; }

        [DataMember(Name = "numPostalCodes")]
        public int? NumberOfPostalCodes { get; internal set; }

        [DataMember(Name = "maxPostalCode")]
        public string MaxPostalCode { get; internal set; }

        [DataMember(Name = "minPostalCode")]
        public string MinPostalCode { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}): {2} - {3} ({4} total)",
                CountryCode, CountryName, MinPostalCode, MaxPostalCode, NumberOfPostalCodes);
        }

    }
}

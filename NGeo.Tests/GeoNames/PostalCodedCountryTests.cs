using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NGeo.GeoNames
{
    [TestClass]
    public class PostalCodedCountryTests
    {
        [TestMethod]
        public void GeoNames_PostalCodedCountry_ShouldBePublic()
        {
            var model = new PostalCodedCountry();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_PostalCodedCountry_ShouldOverrideToString()
        {
            var model = new PostalCodedCountry
            {
                CountryName = "country name",
                CountryCode = "XY",
                MinPostalCode = "min",
                MaxPostalCode = "max",
                NumberOfPostalCodes = -4,
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(string.Format("{0} ({1}): {2} - {3} ({4} total)",
                model.CountryCode, model.CountryName, model.MinPostalCode, model.MaxPostalCode, model.NumberOfPostalCodes));
        }

        [TestMethod]
        public void GeoNames_PostalCodedCountry_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PostalCodedCountry), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_PostalCodedCountry_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<PostalCodedCountry, string>>>
            {
                { "countryCode", p => p.CountryCode },
                { "countryName", p => p.CountryName },
                { "maxPostalCode", p => p.MaxPostalCode },
                { "minPostalCode", p => p.MinPostalCode },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_PostalCodedCountry_NullableIntProperties_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<PostalCodedCountry, int?>>>
            {
                { "numPostalCodes", p => p.NumberOfPostalCodes },
            };

            properties.ShouldHaveDataMemberAttributes();
        }
    }
}

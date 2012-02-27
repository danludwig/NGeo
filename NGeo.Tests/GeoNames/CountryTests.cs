using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NGeo.GeoNames
{
    [TestClass]
    public class CountryTests
    {
        [TestMethod]
        public void GeoNames_Country_ShouldBePublic()
        {
            var model = new Country();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Toponym_StringProperties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new Country
            {
                FipsCode = "   ",
                CapitalCityName = "   ",
                AreaInSqKm = "   ",
                CurrencyCode = "   ",
                Languages = "   ",
            };

            model.ShouldNotBeNull();
            model.FipsCode.ShouldBeNull();
            model.CapitalCityName.ShouldBeNull();
            model.AreaInSqKm.ShouldBeNull();
            model.CurrencyCode.ShouldBeNull();
            model.Languages.ShouldBeNull();
        }

        [TestMethod]
        public void GeoNames_Country_ShouldOverrideToString()
        {
            var model = new Country
            {
                CountryName = "country name",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.CountryName);
        }

        [TestMethod]
        public void GeoNames_Country_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Country), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_Country_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Country, string>>>
            {
                { "continent", p => p.ContinentCode },
                { "continentName", p => p.ContinentName },
                { "countryCode", p => p.CountryCode },
                { "countryName", p => p.CountryName },
                { "isoAlpha3", p => p.IsoAlpha3Code },
                { "fipsCode", p => p.FipsCode },
                { "capital", p => p.CapitalCityName },
                { "areaInSqKm", p => p.AreaInSqKm },
                { "currencyCode", p => p.CurrencyCode },
                { "languages", p => p.Languages },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Country_GeoNameId_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Country, int>>>
            {
                { "geonameId", p => p.GeoNameId },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Country_IsoNumericCode_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Country, int?>>>
            {
                { "isoNumeric", p => p.IsoNumericCode },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Country_Population_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Country, long>>>
            {
                { "population", p => p.Population },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Country_NullabelDoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Country, double?>>>
            {
                { "bBoxWest", p => p.BoundingBoxWest },
                { "bBoxNorth", p => p.BoundingBoxNorth },
                { "bBoxEast", p => p.BoundingBoxEast },
                { "bBoxSouth", p => p.BoundingBoxSouth },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

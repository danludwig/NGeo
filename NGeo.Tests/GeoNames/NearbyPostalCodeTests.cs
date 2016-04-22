using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class NearbyPostalCodeTests
    {
        [TestMethod]
        public void GeoNames_NearbyPostalCode_ShouldBePublic()
        {
            var model = new NearbyPostalCode();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_NearbyPostalCode_StringProperties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new NearbyPostalCode
            {
                Admin1Code = "   ",
                Admin1Name = "   ",
                Admin2Code = "   ",
                Admin2Name = "   ",
                Admin3Code = "   ",
                Admin3Name = "   ",
                CountryCode = "   ",
                Name = "   ",
                Value = "   ",
            };

            model.ShouldNotBeNull();
            model.Admin1Name.ShouldBeNull();
            model.Admin1Code.ShouldBeNull();
            model.Admin2Name.ShouldBeNull();
            model.Admin2Code.ShouldBeNull();
            model.Admin3Name.ShouldBeNull();
            model.Admin3Code.ShouldBeNull();
            model.CountryCode.ShouldBeNull();
            model.Name.ShouldBeNull();
            model.Value.ShouldBeNull();
        }

        [TestMethod]
        public void GeoNames_NearbyPostalCode_ShouldOverrideToString()
        {
            var model = new NearbyPostalCode
            {
                Value = "85254",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Value);
        }

        [TestMethod]
        public void GeoNames_NearbyPostalCode_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(NearbyPostalCode), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_NearbyPostalCode_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<NearbyPostalCode, string>>>
            {
                { "adminCode1", p => p.Admin1Code },
                { "adminName1", p => p.Admin1Name },
                { "adminCode2", p => p.Admin2Code },
                { "adminName2", p => p.Admin2Name },
                { "adminCode3", p => p.Admin3Code },
                { "adminName3", p => p.Admin3Name },
                { "countryCode", p => p.CountryCode },
                { "placeName", p => p.Name },
                { "postalCode", p => p.Value },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_NearbyPostalCode_DoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<NearbyPostalCode, double>>>
            {
                { "lat", p => p.Latitude },
                { "lng", p => p.Longitude },
                { "distance", p => p.Distance },
            };

            properties.ShouldHaveDataMemberAttributes();
        }
    }
}

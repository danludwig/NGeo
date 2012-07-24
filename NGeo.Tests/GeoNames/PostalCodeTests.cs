using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class PostalCodeTests
    {
        [TestMethod]
        public void GeoNames_PostalCode_ShouldBePublic()
        {
            var model = new PostalCode();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_PostalCode_StringProperties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new PostalCode
            {
                Admin1Name = "   ",
                Admin2Name = "   ",
                Admin3Name = "   ",
            };

            model.ShouldNotBeNull();
            model.Admin1Name.ShouldBeNull();
            model.Admin2Name.ShouldBeNull();
            model.Admin3Name.ShouldBeNull();
        }

        [TestMethod]
        public void GeoNames_PostalCode_ShouldOverrideToString()
        {
            var model = new PostalCode
            {
                Name = "name",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

        [TestMethod]
        public void GeoNames_PostalCode_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PostalCode), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_PostalCode_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<PostalCode, string>>>
            {
                { "postalcode", p => p.Value },
                { "placeName", p => p.Name },
                { "countryCode", p => p.CountryCode },
                { "adminCode1", p => p.Admin1Code },
                { "adminName1", p => p.Admin1Name },
                { "adminCode2", p => p.Admin2Code },
                { "adminName2", p => p.Admin2Name },
                { "adminCode3", p => p.Admin3Code },
                { "adminName3", p => p.Admin3Name },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_PostalCode_DoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<PostalCode, double>>>
            {
                { "lat", p => p.Latitude },
                { "lng", p => p.Longitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }
    }
}

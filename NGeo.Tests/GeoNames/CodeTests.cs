using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class CodeTests
    {
        [TestMethod]
        public void GeoNames_Code_ShouldBePublic()
        {
            var model = new Code();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Code_StringProperties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new Code
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
        public void GeoNames_Code_ShouldOverrideToString()
        {
            var model = new Code
            {
                Name = "name",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

        [TestMethod]
        public void GeoNames_Code_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Code), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_Code_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Code, string>>>
            {
                { "postalcode", p => p.PostalCode },
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
        public void GeoNames_Toponym_DoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Code, double>>>
            {
                { "lat", p => p.Latitude },
                { "lng", p => p.Longitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }
    }
}

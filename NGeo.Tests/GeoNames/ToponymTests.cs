using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class ToponymTests
    {
        [TestMethod]
        public void GeoNames_Toponym_ShouldBePublic()
        {
            var model = new Toponym();

            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Toponym_StringProperties_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var model = new Toponym
            {
                CountryName = "   ",
                Admin1Name = "   ",
                Admin2Name = "   ",
                Admin3Name = "   ",
                Admin4Name = "   ",
            };

            model.ShouldNotBeNull();
            model.CountryName.ShouldBeNull();
            model.Admin1Name.ShouldBeNull();
            model.Admin2Name.ShouldBeNull();
            model.Admin3Name.ShouldBeNull();
            model.Admin4Name.ShouldBeNull();
        }

        [TestMethod]
        public void GeoNames_Toponym_ShouldOverrideToString()
        {
            var model = new Toponym
            {
                Name = "name",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

        [TestMethod]
        public void GeoNames_Toponym_AlternateNamesList_ShouldSetAlternateNamesReadOnlyCollection()
        {
            var it = new Toponym
            {
                AlternateNamesList = new List<AlternateName>
                {
                    new AlternateName { Name = "name 1", },
                    new AlternateName { Name = "name 2", },
                    new AlternateName { Name = "name 3", },
                }
            };

            it.ShouldNotBeNull();
            it.AlternateNamesList.ShouldNotBeNull();
            it.AlternateNamesList.Count.ShouldEqual(3);
            it.AlternateNames.ShouldNotBeNull();
            it.AlternateNames.Count.ShouldEqual(it.AlternateNamesList.Count);
            for (var i = 0; i < it.AlternateNames.Count; i++)
                it.AlternateNames[i].Name.ShouldEqual(it.AlternateNamesList[i].Name);
        }

        [TestMethod]
        public void GeoNames_Toponym_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Toponym), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_Toponym_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, string>>>
            {
                { "name", p => p.Name },
                { "toponymName", p => p.ToponymName },
                { "fcl", p => p.FeatureClassCode },
                { "fclName", p => p.FeatureClassName },
                { "fcode", p => p.FeatureCode },
                { "fcodeName", p => p.FeatureName },
                { "continentCode", p => p.ContinentCode },
                { "countryCode", p => p.CountryCode },
                { "countryName", p => p.CountryName },
                { "adminCode1", p => p.Admin1Code },
                { "adminName1", p => p.Admin1Name },
                { "adminCode2", p => p.Admin2Code },
                { "adminName2", p => p.Admin2Name },
                { "adminCode3", p => p.Admin3Code },
                { "adminName3", p => p.Admin3Name },
                { "adminCode4", p => p.Admin4Code },
                { "adminName4", p => p.Admin4Name },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_GeoNameId_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, int>>>
            {
                { "geonameId", p => p.GeoNameId },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_NullableIntProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, int?>>>
            {
                { "numberOfChildren", p => p.ChildCount },
                { "elevation", p => p.Elevation },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_Population_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, long?>>>
            {
                { "population", p => p.Population },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_DoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, double>>>
            {
                { "lat", p => p.Latitude },
                { "lng", p => p.Longitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_AlternateNamesList_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, ICollection<AlternateName>>>>
            {
                { "alternateNames", p => p.AlternateNamesList },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_Toponym_TimeZone_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Toponym, TimeZone>>>
            {
                { "timezone", p => p.TimeZone },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class ResultTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldBePublic()
        {
            var model = new Result();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldConvertParseableStringWoeId_ToNullableInt()
        {
            var model = new Result { WoeIdInternal = "718" };
            model.ShouldNotBeNull();
            model.WoeId.ShouldEqual(718);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldNotConvertUnparseableStringWoeId_ToNullableInt()
        {
            var model = new Result { WoeIdInternal = "cannot parse" };
            model.ShouldNotBeNull();
            model.WoeId.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldConvertParseableStringWoeType_ToNullableInt()
        {
            var model = new Result { WoeTypeInternal = "4" };
            model.ShouldNotBeNull();
            model.WoeType.ShouldEqual(4);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldNotConvertUnparseableStringWoeType_ToNullableInt()
        {
            var model = new Result { WoeTypeInternal = "cannot parse" };
            model.ShouldNotBeNull();
            model.WoeType.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Result), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Result, string>>>
            {
                { "name", p => p.Name },
                { "line1", p => p.Line1 },
                { "line2", p => p.Line2 },
                { "line3", p => p.Line3 },
                { "line4", p => p.Line4 },
                { "street", p => p.Street },
                { "xstreet", p => p.CrossStreet },
                { "cross", p => p.CrossStreets },
                { "house", p => p.HouseNumber },
                { "unittype", p => p.UnitType },
                { "unit", p => p.Unit },
                { "postal", p => p.Postal },
                { "uzip", p => p.UniqueZipCode },
                { "neighborhood", p => p.Neighborhood },
                { "city", p => p.CityName },
                { "county", p => p.CountyName },
                { "countycode", p => p.CountyCode },
                { "state", p => p.StateName },
                { "statecode", p => p.StateCode },
                { "country", p => p.CountryName },
                { "countrycode", p => p.CountryCode },
                { "level4", p => p.Level4Name },
                { "level3", p => p.Level3Name },
                { "level2", p => p.Level2Name },
                { "level2code", p => p.Level2Code },
                { "level1", p => p.Level1Name },
                { "level1code", p => p.Level1Code },
                { "level0", p => p.Level0Name },
                { "level0code", p => p.Level0Code },
                { "timezone", p => p.TimeZone },
                { "airport", p => p.AirportCode },
                { "areacode", p => p.AreaCode },
                { "hash", p => p.Hash },
                { "woeid", p => p.WoeIdInternal },
                { "woetype", p => p.WoeTypeInternal },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_IntProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Result, int>>>
            {
                { "quality", p => p.Quality },
                { "radius", p => p.RadiusInMeters },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_DoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Result, double>>>
            {
                { "latitude", p => p.Latitude },
                { "longitude", p => p.Longitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_NullableDoubleProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Result, double?>>>
            {
                { "offsetlat", p => p.OffsetLatitude },
                { "offsetlon", p => p.OffsetLongitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Result_BoundingBox_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Result, BoundingBox>>>
            {
                { "boundingbox", p => p.BoundingBox },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

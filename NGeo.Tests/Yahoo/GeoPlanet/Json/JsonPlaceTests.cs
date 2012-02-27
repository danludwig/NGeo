using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonPlaceTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_ShouldBePublic()
        {
            var model = new JsonPlace();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(JsonPlace), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, string>>>
            {
                { "lang", p => p.Language },
                { "name", p => p.Name },
                { "placeTypeName", p => p.TypeName },
                { "country", p => p.CountryName },
                { "admin1", p => p.Admin1Name },
                { "admin2", p => p.Admin2Name },
                { "admin3", p => p.Admin3Name },
                { "locality1", p => p.Locality1Name },
                { "locality2", p => p.Locality2Name },
                { "postal", p => p.Postal },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_Uri_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, Uri>>>
            {
                { "uri", p => p.Uri },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_IntProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, int>>>
            {
                { "woeid", p => p.WoeId },
                { "areaRank", p => p.AreaRank },
                { "popRank", p => p.PopulationRank },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_Type_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, JsonPlaceTypeAttributes>>>
            {
                { "placeTypeName attrs", p => p.Type },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_JsonAdminAttributes_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, JsonAdminAttributes>>>
            {
                { "country attrs", p => p.Country },
                { "admin1 attrs", p => p.Admin1 },
                { "admin2 attrs", p => p.Admin2 },
                { "admin3 attrs", p => p.Admin3 },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_JsonLocalityAttributes_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, JsonLocalityAttributes>>>
            {
                { "locality1 attrs", p => p.Locality1 },
                { "locality2 attrs", p => p.Locality2 },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_Center_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, Point>>>
            {
                { "centroid", p => p.Center },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlace_BoundingBox_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlace, BoundingBox>>>
            {
                { "boundingBox", p => p.BoundingBox },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

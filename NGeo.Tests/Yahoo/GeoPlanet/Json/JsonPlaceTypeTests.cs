using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonPlaceTypeTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceType_ShouldBePublic()
        {
            var model = new JsonPlaceType();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceType_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(JsonPlaceType), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceType_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlaceType, string>>>
            {
                { "lang", p => p.Language },
                { "placeTypeName", p => p.Name },
                { "placeTypeDescription", p => p.Description },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceType_Uri_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlaceType, Uri>>>
            {
                { "uri", p => p.Uri },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceType_JsonAttributes_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlaceType, JsonPlaceTypeAttributes>>>
            {
                { "placeTypeName attrs", p => p.JsonAttributes },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

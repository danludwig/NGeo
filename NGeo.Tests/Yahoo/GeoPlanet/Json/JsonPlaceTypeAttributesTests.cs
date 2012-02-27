using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonPlaceTypeAttributesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceTypeAttributes_ShouldBePublic()
        {
            var model = new JsonPlaceTypeAttributes();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceTypeAttributes_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(JsonPlaceTypeAttributes), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonPlaceTypeAttributes_Code_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonPlaceTypeAttributes, int>>>
            {
                { "code", p => p.Code },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

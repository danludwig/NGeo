using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonLocalityAttributesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_JsonLocalityAttributes_ShouldBePublic()
        {
            var model = new JsonLocalityAttributes();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonLocalityAttributes_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(JsonLocalityAttributes), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonLocalityAttributes_Type_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonLocalityAttributes, string>>>
            {
                { "type", p => p.Type },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

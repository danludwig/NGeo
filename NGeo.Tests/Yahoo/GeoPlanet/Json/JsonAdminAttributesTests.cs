using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonAdminAttributesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_JsonAdminAttributes_ShouldBePublic()
        {
            var model = new JsonAdminAttributes();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonAdminAttributes_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(JsonAdminAttributes), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonAdminAttributes_StringProperties_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<JsonAdminAttributes, string>>>
            {
                { "code", p => p.Code },
                { "type", p => p.Type },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

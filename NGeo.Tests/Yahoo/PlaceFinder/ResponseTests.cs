using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class ResponseTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_Response_ShouldBePublic()
        {
            var model = new Response();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Response_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Response), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Response_Results_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<Response, ResultSet>>>
            {
                { "ResultSet", p => p.ResultSet },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

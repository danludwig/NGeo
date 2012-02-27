using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class RequestViewTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_RequestView_ShouldHave2Members()
        {
            ((int)RequestView.Short).ShouldEqual(0);
            ((int)RequestView.Long).ShouldEqual(1);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_RequestView_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(RequestView), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_RequestView_ShouldHaveEnumMemberAttributes()
        {
            var enumMembers = new Dictionary<RequestView, string>
            {
                { RequestView.Short, "short" },
                { RequestView.Long, "long" },
            };

            var values = Enum.GetValues(typeof(RequestView)) as RequestView[];
            values.ShouldNotBeNull();

            Debug.Assert(values != null);
            foreach (var value in values)
            {
                value.ShouldHaveEnumMemberAttribute(enumMembers[value]);
            }
        }

    }
}

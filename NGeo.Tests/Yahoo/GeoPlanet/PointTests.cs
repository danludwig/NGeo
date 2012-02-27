using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_Point_ShouldBePublic()
        {
            var model = new Point();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Point_ShouldOverrideToString()
        {
            var model = new Point { Latitude = 6.9, Longitude = 3.3 };
            model.ShouldNotBeNull();
            model.ToString().ShouldEqual("6.9,3.3");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Point_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Point), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Point_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Point, double>>>
            {
                { "latitude", p => p.Latitude },
                { "longitude", p => p.Longitude },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

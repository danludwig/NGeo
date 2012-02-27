using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class BoundingBoxTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_BoundingBox_ShouldBePublic()
        {
            var model = new BoundingBox();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_BoundingBox_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(BoundingBox), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_BoundingBox_PointProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<BoundingBox, Point>>>
            {
                { "southWest", p => p.Southwest },
                { "northEast", p => p.Northeast },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

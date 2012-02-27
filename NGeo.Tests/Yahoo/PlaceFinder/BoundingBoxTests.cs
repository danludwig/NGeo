using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class BoundingBoxTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_BoundingBox_ShouldBePublic()
        {
            var model = new BoundingBox();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_BoundingBox_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(BoundingBox), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var doubleProperties = new Dictionary<string, Expression<Func<BoundingBox, double>>>
            {
                { "north", p => p.North },
                { "south", p => p.South },
                { "east", p => p.East },
                { "west", p => p.West },
            };

            doubleProperties.ShouldHaveDataMemberAttributes();
        }

    }
}

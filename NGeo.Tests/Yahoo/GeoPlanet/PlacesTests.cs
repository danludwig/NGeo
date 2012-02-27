using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlacesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_Places_ShouldBePublic()
        {
            var it = new Places
            {
                Items = new ReadOnlyCollection<Place>(new List<Place>()),
            };
            it.ShouldNotBeNull();
            it.Items.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Places_ShouldImplementIEnumerableOfPlaces()
        {
            var it = new Places
            {
                Items = new ReadOnlyCollection<Place>(new List<Place>()),
            };
            it.ShouldNotBeNull();
            it.ShouldImplement<IEnumerable<Place>>();
            it.GetEnumerator().ShouldNotBeNull();
            ((IEnumerable) it).GetEnumerator().ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Places_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Places), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Places_IntProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<Places, int>>>
            {
                { "start", p => p.Start },
                { "count", p => p.Count },
                { "total", p => p.Total },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

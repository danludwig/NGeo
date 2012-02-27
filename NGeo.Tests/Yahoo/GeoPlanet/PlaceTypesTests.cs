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
    public class PlaceTypesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypes_ShouldBePublic()
        {
            var it = new PlaceTypes
            {
                Items = new ReadOnlyCollection<PlaceType>(new List<PlaceType>()),
            };
            it.ShouldNotBeNull();
            it.Items.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypes_ShouldImplementIEnumerableOfPlaceTypes()
        {
            var it = new PlaceTypes
            {
                Items = new ReadOnlyCollection<PlaceType>(new List<PlaceType>()),
            };
            it.ShouldNotBeNull();
            it.ShouldImplement<IEnumerable<PlaceType>>();
            it.GetEnumerator().ShouldNotBeNull();
            ((IEnumerable) it).GetEnumerator().ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypes_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PlaceTypes), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypes_IntProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<PlaceTypes, int>>>
            {
                { "start", p => p.Start },
                { "count", p => p.Count },
                { "total", p => p.Total },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class HierarchyTests
    {
        [TestMethod]
        public void GeoNames_Hierarchy_ShouldBePublic()
        {
            var model = new Hierarchy
            {
                ItemsList = new List<Toponym>
                {
                    new Toponym(), new Toponym(),
                },
            };

            model.ShouldNotBeNull();
            model.ItemsList.ShouldNotBeNull();
            model.ItemsList.Count.ShouldEqual(2);
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldImplementIEnumerableOfToponyms()
        {
            var model = new Hierarchy
            {
                ItemsList = new List<Toponym>
                {
                    new Toponym(), new Toponym(),
                },
            };

            model.ShouldImplement(typeof(IEnumerable<Toponym>));
            model.GetEnumerator().ShouldNotBeNull();
            ((IEnumerable) model).GetEnumerator().ShouldNotBeNull();
            foreach (var item in model)
            {
                item.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ItemsList_ShouldSetItemsReadOnlyCollection()
        {
            var it = new Hierarchy
            {
                ItemsList = new List<Toponym>
                {
                    new Toponym { Name = "name 1", },
                    new Toponym { Name = "name 2", },
                    new Toponym { Name = "name 3", },
                }
            };

            it.ShouldNotBeNull();
            it.ItemsList.ShouldNotBeNull();
            it.ItemsList.Count.ShouldEqual(3);
            it.Items.ShouldNotBeNull();
            it.Items.Count.ShouldEqual(it.ItemsList.Count);
            for (var i = 0; i < it.Items.Count; i++)
                it.Items[i].Name.ShouldEqual(it.ItemsList[i].Name);
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Hierarchy), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_Hierarchy_Items_ShouldHaveDataMemberAttribute()
        {
            var genericListProperties = new Dictionary<string, Expression<Func<Hierarchy, List<Toponym>>>>
            {
                { "geonames", p => p.ItemsList },
            };

            genericListProperties.ShouldHaveDataMemberAttributes();
        }

    }
}

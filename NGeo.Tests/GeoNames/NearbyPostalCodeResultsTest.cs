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
    public class NearbyPostalCodeResultsTests
    {
        [TestMethod]
        public void GeoNames_Results_ShouldBePublic()
        {
            var model = new NearbyPostalCodeResults
            {
                Items = new List<NearbyPostalCode>
                {
                    new NearbyPostalCode(), new NearbyPostalCode(), new NearbyPostalCode(),
                },
            };

            model.ShouldNotBeNull();
            model.Items.ShouldNotBeNull();
            model.Items.Count.ShouldEqual(3);
        }

        [TestMethod]
        public void GeoNames_Results_ShouldImplementGenericIEnumerable()
        {
            var model = new NearbyPostalCodeResults
            {
                Items = new List<NearbyPostalCode>
                {
                    new NearbyPostalCode(), new NearbyPostalCode(), new NearbyPostalCode(),
                },
            };

            model.ShouldImplement(typeof(IEnumerable<object>));
            model.GetEnumerator().ShouldNotBeNull();
            ((IEnumerable)model).GetEnumerator().ShouldNotBeNull();
            foreach (var item in model)
            {
                item.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Results_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(NearbyPostalCodeResults), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_Results_Items_ShouldHaveDataMemberAttribute()
        {
            var genericListProperties = new Dictionary<string, Expression<Func<Results<object>, List<object>>>>
            {
                { "geonames", p => p.Items },
            };

            genericListProperties.ShouldHaveDataMemberAttributes();
        }

    }
}

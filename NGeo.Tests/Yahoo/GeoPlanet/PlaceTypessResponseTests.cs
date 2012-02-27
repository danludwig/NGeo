using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlaceTypesResponseTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypesResponse_ShouldBePublic()
        {
            var it = new PlaceTypesResponse();
            it.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceTypesResponse_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PlaceTypesResponse), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

    }
}

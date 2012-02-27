using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlacesResponseTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_PlacesResponse_ShouldBePublic()
        {
            var it = new PlacesResponse();
            it.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlacesResponse_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PlacesResponse), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

    }
}

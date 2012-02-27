using System;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlaceResponseTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceResponse_ShouldBePublic()
        {
            var it = new PlaceResponse();

            it.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceResponse_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(PlaceResponse), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

    }
}

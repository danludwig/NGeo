using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByFullyParsedAddressTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFullyParsedAddress_ShouldPreserveUnitType()
        {
            var it = new PlaceByFullyParsedAddress
            {
                UnitType = "unit type",
            };

            it.ShouldNotBeNull();
            it.UnitType.ShouldEqual("unit type");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFullyParsedAddress_ShouldPreserveUnit()
        {
            var it = new PlaceByFullyParsedAddress
            {
                Unit = "unit",
            };

            it.ShouldNotBeNull();
            it.Unit.ShouldEqual("unit");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFullyParsedAddress_ShouldPreserveCrossStreet()
        {
            var it = new PlaceByFullyParsedAddress
            {
                CrossStreet = "cross street",
            };

            it.ShouldNotBeNull();
            it.CrossStreet.ShouldEqual("cross street");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFullyParsedAddress_ShouldPreserveNeighborhood()
        {
            var it = new PlaceByFullyParsedAddress
            {
                Neighborhood = "neighborhood",
            };

            it.ShouldNotBeNull();
            it.Neighborhood.ShouldEqual("neighborhood");
        }

    }
}

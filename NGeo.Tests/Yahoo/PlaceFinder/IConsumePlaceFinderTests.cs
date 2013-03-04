using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class ConsumePlaceFinderTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_IConsumePlaceFinder_ShouldImplementIDisposable()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Object.ShouldImplement<IDisposable>();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByCoordinates_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByCoordinates>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByCoordinates, null, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByFreeformText_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByFreeformText>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByFreeformText, null, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByName_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByName>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByName, null, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByWoeId_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByWoeId>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByWoeId, null, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByMultilineAddress_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByMultilineAddress>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByMultilineAddress, null, null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByFullyParsedAddress_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByFullyParsedAddress>(), null, null))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByFullyParsedAddress, null, null);
            result.ShouldNotBeNull();
        }

    }
}

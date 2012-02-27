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
            contract.Setup(m => m.Find(It.IsAny<PlaceByCoordinates>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByCoordinates);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByFreeformText_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByFreeformText>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByFreeformText);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByName_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByName>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByName);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByWoeId_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByWoeId>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByWoeId);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByMultilineAddress_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByMultilineAddress>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByMultilineAddress);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_FindByFullyParsedAddress_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IConsumePlaceFinder>();
            contract.Setup(m => m.Find(It.IsAny<PlaceByFullyParsedAddress>()))
                .Returns(new ResultSet());
            var result = contract.Object.Find(null as PlaceByFullyParsedAddress);
            result.ShouldNotBeNull();
        }

    }
}

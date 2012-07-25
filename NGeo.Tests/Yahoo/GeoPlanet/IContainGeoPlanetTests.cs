using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class ContainGeoPlanetTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_IContainGeoPlanet_ShouldImplementIDisposable()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Object.ShouldImplement<IDisposable>();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Place_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Place(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Place());
            var results = contract.Object.Place(0);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Places_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Places(It.IsAny<string>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var results = contract.Object.Places("test");
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Parent_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Parent(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Place());
            var result = contract.Object.Parent(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Ancestors_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Ancestors(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Ancestors(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_BelongTos_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.BelongTos(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.BelongTos(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Types_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Types(It.IsAny<RequestView>()))
                .Returns(new PlaceTypes());
            var result = contract.Object.Types();
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Type_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Type(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new PlaceType());
            var result = contract.Object.Type(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Continents_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Continents(It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Continents();
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Countries_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Countries(It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Countries();
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_States_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.States(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.States(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Level1Admins_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Level1Admins(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Level1Admins(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Counties_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Counties(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Counties(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Level2Admins_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Level2Admins(It.IsAny<int>(), It.IsAny<RequestView>()))
                .Returns(new Places());
            var result = contract.Object.Level2Admins(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Concordance_WithStringId_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Concordance(It.IsAny<ConcordanceNamespace>(), It.IsAny<string>()))
                .Returns(new ConcordanceResponse());
            var result = contract.Object.Concordance(default(ConcordanceNamespace), null);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Concordance_WithIntId_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoPlanet>();
            contract.Setup(m => m.Concordance(It.IsAny<ConcordanceNamespace>(), It.IsAny<int>()))
                .Returns(new ConcordanceResponse());
            var result = contract.Object.Concordance(default(ConcordanceNamespace), 0);
            result.ShouldNotBeNull();
        }

    }
}

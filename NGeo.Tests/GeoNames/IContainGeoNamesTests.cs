using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class ContainGeoNamesTests
    {
        [TestMethod]
        public void GeoNames_IContainGeoNames_ShouldImplementIDisposable()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Object.ShouldImplement<IDisposable>();
        }

        [TestMethod]
        public void GeoNames_FindNearbyPlaceName_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.FindNearbyPlaceName(It.IsAny<NearbyPlaceNameFinder>()))
                .Returns(new ReadOnlyCollection<Toponym>(new List<Toponym>()));
            var results = contract.Object.FindNearbyPlaceName(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_LookupPostalCode_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.LookupPostalCode(It.IsAny<PostalCodeLookup>()))
                .Returns(new ReadOnlyCollection<PostalCode>(new List<PostalCode>()));
            var results = contract.Object.LookupPostalCode(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_FindNearbyPostalCodes_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.FindNearbyPostalCodes(It.IsAny<NearbyPostalCodesFinder>()))
                .Returns(new ReadOnlyCollection<NearbyPostalCode>(new List<NearbyPostalCode>()));
            var results = contract.Object.FindNearbyPostalCodes(null);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_PostalCodeCountryInfo_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.PostalCodeCountryInfo())
                .Returns(new ReadOnlyCollection<PostalCodedCountry>(new List<PostalCodedCountry>()));
            var results = contract.Object.PostalCodeCountryInfo();
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Get_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(new Toponym());
            var result = contract.Object.Get(0);
            result.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Children_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.Children(It.IsAny<int>(), It.IsAny<ResultStyle>(), It.IsAny<int>()))
                .Returns(new ReadOnlyCollection<Toponym>(new List<Toponym>()));
            var results = contract.Object.Children(0);
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Countries_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.Countries())
                .Returns(new ReadOnlyCollection<Country>(new List<Country>()));
            var results = contract.Object.Countries();
            results.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldBeInterfaceMethod()
        {
            var contract = new Mock<IContainGeoNames>();
            contract.Setup(m => m.Hierarchy(It.IsAny<int>(), It.IsAny<ResultStyle>()))
                .Returns(new Hierarchy());
            var results = contract.Object.Hierarchy(0);
            results.ShouldNotBeNull();
        }

    }
}

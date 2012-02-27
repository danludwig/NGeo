using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class QualityDescriptionTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_QualityDescription_ShouldHave29Members()
        {
            ((int)QualityDescription.NotAnAddress).ShouldEqual(0);
            ((int)QualityDescription.CountryLevel0IgnoreLevel1).ShouldEqual(9);
            ((int)QualityDescription.CountryLevel0).ShouldEqual(10);
            ((int)QualityDescription.StateOrProvinceLevel1IgnoreLevel2).ShouldEqual(19);
            ((int)QualityDescription.StateOrProvinceLevel1).ShouldEqual(20);
            ((int)QualityDescription.CountyLevel2IgnoreLevel3).ShouldEqual(29);
            ((int)QualityDescription.CountyLevel2).ShouldEqual(30);
            ((int)QualityDescription.CityTownOrLocalityLevel3IgnoreLevel4).ShouldEqual(39);
            ((int)QualityDescription.CityTownOrLocalityLevel3).ShouldEqual(40);
            ((int)QualityDescription.NeighborhoodLevel4IgnoreStreet).ShouldEqual(49);
            ((int)QualityDescription.NeighborhoodLevel4).ShouldEqual(50);
            ((int)QualityDescription.PostalDistrictIgnoreStreet).ShouldEqual(59);
            ((int)QualityDescription.PostalDistrict).ShouldEqual(60);
            ((int)QualityDescription.Airport).ShouldEqual(62);
            ((int)QualityDescription.AreaOfInterest).ShouldEqual(63);
            ((int)QualityDescription.PostalZoneOrSectorIgnoreStreet).ShouldEqual(64);

            ((int)QualityDescription.StreetMismatch).ShouldEqual(70);
            ((int)QualityDescription.StreetMismatchIgnoreAddress).ShouldEqual(71);
            ((int)QualityDescription.StreetMatch).ShouldEqual(72);
            ((int)QualityDescription.PostalUnitOrSegmentIgnoreStreet).ShouldEqual(74);
            ((int)QualityDescription.PostalUnitOrSegment).ShouldEqual(75);

            ((int)QualityDescription.IntersectionWithStreetMismatch).ShouldEqual(80);
            ((int)QualityDescription.IntersectionWithStreetMatch).ShouldEqual(82);
            ((int)QualityDescription.AddressMismatchWithStreetMismatch).ShouldEqual(84);
            ((int)QualityDescription.AddressMatchWithStreetMismatch).ShouldEqual(85);
            ((int)QualityDescription.AddressMismatchWithStreetMatch).ShouldEqual(86);
            ((int)QualityDescription.AddressMatchWithStreetMatch).ShouldEqual(87);
            ((int)QualityDescription.PointOfInterest).ShouldEqual(90);
            ((int)QualityDescription.Coordinate).ShouldEqual(99);
        }

    }
}

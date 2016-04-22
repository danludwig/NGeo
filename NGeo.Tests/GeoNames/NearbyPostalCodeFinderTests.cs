using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class NearbyPostalCodeFinderTests
    {
        [TestMethod]
        public void GeoNames_NearbyPlaceNameFinder_ShouldBePublic()
        {
            var finder = new NearbyPostalCodesFinder
            {
                Latitude = 90.0,
                Longitude = 180.0,
                UserName = "username",
                Language = "language",
                RadiusInKm = 1.0,
                MaxRows = 2,
                Style = ResultStyle.Medium,
            };

            finder.ShouldNotBeNull();
            finder.Latitude.ShouldEqual(90.0);
            finder.Longitude.ShouldEqual(180.0);
            finder.UserName.ShouldNotBeNull();
            finder.Language.ShouldNotBeNull();
            finder.MaxRows.ShouldEqual(2);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }

        [TestMethod]
        public void GeoNames_NearbyPlaceNameFinder_ShouldHaveDefaultValues()
        {
            var finder = new NearbyPostalCodesFinder();

            finder.ShouldNotBeNull();
            finder.Latitude.ShouldEqual(0.0);
            finder.Longitude.ShouldEqual(0.0);
            finder.UserName.ShouldBeNull();
            finder.Language.ShouldEqual("local");
            finder.RadiusInKm.ShouldEqual(0.0);
            finder.MaxRows.ShouldEqual(100);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class NearbyPlaceNameFinderTests
    {
        [TestMethod]
        public void GeoNames_NearbyPlaceNameFinder_ShouldBePublic()
        {
            var finder = new NearbyPlaceNameFinder
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
            finder.RadiusInKm.HasValue.ShouldBeTrue();
            finder.MaxRows.ShouldEqual(2);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }

        [TestMethod]
        public void GeoNames_NearbyPlaceNameFinder_ShouldHaveDefaultValues()
        {
            var finder = new NearbyPlaceNameFinder();

            finder.ShouldNotBeNull();
            finder.Latitude.ShouldEqual(0.0);
            finder.Longitude.ShouldEqual(0.0);
            finder.UserName.ShouldBeNull();
            finder.Language.ShouldEqual("local");
            finder.RadiusInKm.ShouldBeNull();
            finder.MaxRows.ShouldEqual(100);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class TimeZoneLookupTests
    {
        [TestMethod]
        public void GeoNames_PostalCodeLookup_ShouldBePublic()
        {
            var lookup = new TimeZoneLookup
            {
                UserName = "username",
                Language = "swahili",
                Latitude = 1.0,
                Longitude = 2.0,
                RadiusInKm = 3.0,
            };

            lookup.ShouldNotBeNull();
            lookup.UserName.ShouldNotBeNull();
            lookup.Language.ShouldNotBeNull();
            lookup.Latitude.ShouldEqual(1.0);
            lookup.Longitude.ShouldEqual(2.0);
            lookup.RadiusInKm.ShouldEqual(3.0);
        }

        [TestMethod]
        public void GeoNames_PostalCodeLookup_ShouldHaveDefaultValues()
        {
            var lookup = new TimeZoneLookup();

            lookup.ShouldNotBeNull();
            lookup.UserName.ShouldBeNull();
            lookup.Language.ShouldEqual("local");
            lookup.Latitude.ShouldEqual(0.0);
            lookup.Longitude.ShouldEqual(0.0);
            lookup.RadiusInKm.ShouldEqual(0.0);
        }
    }
}

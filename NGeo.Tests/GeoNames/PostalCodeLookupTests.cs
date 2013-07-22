using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class PostalCodeLookupTests
    {
        [TestMethod]
        public void GeoNames_PostalCodeLookup_ShouldBePublic()
        {
            var finder = new PostalCodeLookup
            {
                PostalCode = "32819",
                Country = "US",
                UserName = "username",
                MaxRows = 2,
                Style = ResultStyle.Medium,
            };

            finder.ShouldNotBeNull();
            finder.PostalCode.ShouldEqual("32819");
            finder.Country.ShouldEqual("US");
            finder.UserName.ShouldNotBeNull();
            finder.MaxRows.ShouldEqual(2);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }

        [TestMethod]
        public void GeoNames_PostalCodeNearbyLookup_ShouldBePublic()
        {
            var finder = new PostalCodeLookup
            {
                PostalCode = "32819",
                RadiusInKm = 15,
                Country = "US",
                UserName = "username",
                MaxRows = 2,
                Style = ResultStyle.Medium,
            };

            finder.ShouldNotBeNull();
            finder.PostalCode.ShouldEqual("32819");
            finder.RadiusInKm.ShouldEqual(15);
            finder.Country.ShouldEqual("US");
            finder.UserName.ShouldNotBeNull();
            finder.MaxRows.ShouldEqual(2);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }

        [TestMethod]
        public void GeoNames_PostalCodeLookup_ShouldHaveDefaultValues()
        {
            var finder = new PostalCodeLookup();

            finder.ShouldNotBeNull();
            finder.PostalCode.ShouldBeNull();
            finder.Country.ShouldBeNull();
            finder.UserName.ShouldBeNull();
            finder.MaxRows.ShouldEqual(20);
            finder.Style.ShouldEqual(ResultStyle.Medium);
        }
    }
}

using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class GeoNamesContainerTests
    {
        private static readonly string UserName = ConfigurationManager.AppSettings["GeoNamesUserName"];

        [TestMethod]
        public void GeoNames_GeoNamesContainer_ShouldBePublic()
        {
            using (var client = new GeoNamesContainer(null))
            {
                client.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_GeoNamesContainer_ShouldImplementIConsumeGeoNames()
        {
            using (var client = new GeoNamesContainer(null))
            {
                client.ShouldImplement(typeof (IContainGeoNames));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GeoNames_LookupPostalCode_ShouldThrowException_WhenArgIsNull()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                geoNames.LookupPostalCode(null);
            }
        }

        [TestMethod]
        public void GeoNames_LookupPostalCode_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                var finder = new PostalCodeLookup();
                var results = geoNames.LookupPostalCode(finder);
                results.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_LookupPostalCode_ShouldReturn1Result_ForOrlando()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var finder = new PostalCodeLookup
                {
                    PostalCode = "32819",
                    Country = "US",
                };
                var results = geoNames.LookupPostalCode(finder);

                results.ShouldNotBeNull();
                results.Count.ShouldEqual(1);
                results[0].Latitude.ShouldEqual(28.452157);
                results[0].Longitude.ShouldEqual(-81.46784);
                results[0].Name.ShouldEqual("Orlando");
            }
        }

        [TestMethod]
        public void GeoNames_PostalCodeCountryInfo_ShouldReturnMultipleResults()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var results = geoNames.PostalCodeCountryInfo();
                results.ShouldNotBeNull();
                results.Count.ShouldBeInRange(2, int.MaxValue);
            }
        }

        [TestMethod]
        public void GeoNames_PostalCodeCountryInfo_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                var results = geoNames.PostalCodeCountryInfo();
                results.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_FindNearbyPlaceName_ShouldReturn1Result_ForLehighLatitudeAndLongitude_WhenNoRadiusIsSpecified()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var finder = new NearbyPlaceNameFinder
                {
                    Latitude = 40.60326613801468,
                    Longitude = -75.37771224975586,
                };
                var results = geoNames.FindNearbyPlaceName(finder);

                results.ShouldNotBeNull();
                results.Count.ShouldEqual(1);
                results[0].GeoNameId.ShouldEqual(5216771);
                results[0].Name.ShouldEqual("University Heights");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GeoNames_FindNearbyPlaceName_ShouldThrowException_WhenArgIsNull()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                geoNames.FindNearbyPlaceName(null);
            }
        }

        [TestMethod]
        public void GeoNames_FindNearbyPlaceName_ShouldReturn10Results_ForLehighLatitudeAndLongitude_When10KmRadiusIsSpecified()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var finder = new NearbyPlaceNameFinder
                {
                    Latitude = 40.60326613801468,
                    Longitude = -75.37771224975586,
                    RadiusInKm = 10.0,
                    MaxRows = 10,
                };
                var results = geoNames.FindNearbyPlaceName(finder);

                results.ShouldNotBeNull();
                results.Count.ShouldEqual(10);
                results[0].GeoNameId.ShouldEqual(5216771);
                results[0].Name.ShouldEqual("University Heights");
            }
        }

        [TestMethod]
        public void GeoNames_FindNearbyPlaceName_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                var finder = new NearbyPlaceNameFinder();
                var results = geoNames.FindNearbyPlaceName(finder);
                results.ShouldBeNull();
            }
        }
        
        [TestMethod]
        public void GeoNames_FindNearbyPostalCodes_ShouldReturn1Result_ForMollysLatitudeAndLongitude_WhenNoRadiusIsSpecified()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var finder = new NearbyPostalCodesFinder
                {
                    Latitude = 40.611271,
                    Longitude = -75.378110,
                };
                var results = geoNames.FindNearbyPostalCodes(finder);

                results.ShouldNotBeNull();
                results.Count.ShouldEqual(1);
                results[0].Value.ShouldEqual("18015");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GeoNames_FindNearbyPostalCodes_ShouldThrowException_WhenArgIsNull()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                geoNames.FindNearbyPostalCodes(null);
            }
        }

        [TestMethod]
        public void GeoNames_FindNearbyPostalCodes_ShouldReturn10Results_ForMollysLatitudeAndLongitude_When10KmRadiusIsSpecified()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var finder = new NearbyPostalCodesFinder
                {
                    Latitude = 40.611271,
                    Longitude = -75.378110,
                    RadiusInKm = 10.0,
                    MaxRows = 10,
                };
                var results = geoNames.FindNearbyPostalCodes(finder);

                results.ShouldNotBeNull();
                results.Count.ShouldEqual(10);
                results[0].Value.ShouldEqual("18015");
            }
        }

        [TestMethod]
        public void GeoNames_FindNearbyPostalCodes_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                var finder = new NearbyPostalCodesFinder();
                var results = geoNames.FindNearbyPostalCodes(finder);
                results.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Get_ShouldReturn1EarthResult_ForGeoNameId6295630()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var result = geoNames.Get(6295630);

                result.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Get_ShouldReturnNull_ForGeoNameId921810()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var result = geoNames.Get(921810);

                result.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Children_ShouldReturn7Results_ForGeoNameId6295630()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                const int geoNameId = 6295630;
                var results = geoNames.Children(geoNameId);

                results.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Children_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                const int geoNameId = 6295630;
                var results = geoNames.Children(geoNameId);
                results.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Countries_ShouldReturnResults()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                var results = geoNames.Countries();

                results.ShouldNotBeNull();
                results.Count.ShouldBeInRange(1, 300);
            }
        }

        [TestMethod]
        public void GeoNames_Countries_ShouldReturnNull_WithoutUserName()
        {
            using (var geoNames = new GeoNamesContainer(null))
            {
                var results = geoNames.Countries();

                results.ShouldBeNull();
            }
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldReturn1Result_ForGeoNameId6295630()
        {
            using (var geoNames = new GeoNamesContainer(UserName))
            {
                const int geoNameId = 6295630;
                var results = geoNames.Hierarchy(geoNameId, ResultStyle.Full);

                results.ShouldNotBeNull();
                results.ItemsList.ShouldNotBeNull();
                results.ItemsList.Count.ShouldEqual(1);
                results.ItemsList[0].AlternateNames.ShouldNotBeNull();
                results.ItemsList[0].AlternateNames.Count.ShouldBeInRange(1, int.MaxValue);
            }
        }

        [TestMethod]
        public void GeoNames_Hierarchy_ShouldReturnNull_WhenItemsIsNull()
        {
            using (var geoNames = new GeoNamesContainer("asdf;fdks*"))
            {
                const int geoNameId = 6295630;
                var results = geoNames.Hierarchy(geoNameId, ResultStyle.Full);

                results.ShouldBeNull();
            }
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByCoordinatesTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldConstructWithLatitudeAndLongitude()
        {
            var it = new PlaceByCoordinates(55.555, 111.111);

            it.ShouldNotBeNull();
            it.Latitude.ShouldEqual(55.555);
            it.Longitude.ShouldEqual(111.111);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldAllowLatitudeToBeChanged_AfterConstruction()
        {
            var it = new PlaceByCoordinates(55.555, 111.111) { Latitude = 44.444 };

            it.ShouldNotBeNull();
            it.Latitude.ShouldEqual(44.444);
            it.Longitude.ShouldEqual(111.111);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldAllowLongitudeToBeChanged_AfterConstruction()
        {
            var it = new PlaceByCoordinates(55.555, 111.111) { Longitude = 88.888 };

            it.ShouldNotBeNull();
            it.Latitude.ShouldEqual(55.555);
            it.Longitude.ShouldEqual(88.888);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_Location_ShouldConvertLatitudeAndLongitudeToStringRepresentation()
        {
            var it = new PlaceByCoordinates(55.555, 111.111);

            it.ShouldNotBeNull();
            it.Location.ShouldEqual("55.555 111.111");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Latitude must be between -90.0 and 90.0.")]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldThrowException_WhenLatitudeIsLessThanNegative90()
        {
            new PlaceByCoordinates(-90.0001, 111.111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Latitude must be between -90.0 and 90.0.")]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldThrowException_WhenLatitudeIsGreaterThan90()
        {
            new PlaceByCoordinates(90.0001, 111.111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Longitude must be between -180.0 and 180.0.")]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldThrowException_WhenLongitudeIsLessThanNegative180()
        {
            new PlaceByCoordinates(55.555, -180.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Longitude must be between -180.0 and 180.0.")]
        public void Yahoo_PlaceFinder_PlaceByCoordinates_ShouldThrowException_WhenLongitudeIsGreaterThan180()
        {
            new PlaceByCoordinates(55.555, 180.0001);
        }

    }
}

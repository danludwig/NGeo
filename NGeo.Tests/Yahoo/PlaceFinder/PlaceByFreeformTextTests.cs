using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByFreeformTextTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFreeformText_ShouldConstructWithLatitudeAndLongitude()
        {
            var it = new PlaceByFreeformText("free form text");

            it.ShouldNotBeNull();
            it.Location.ShouldEqual("free form text");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByFreeformText_ShouldAllowLocationToBeChanged_AfterConstruction()
        {
            var it = new PlaceByFreeformText("free form text") { Location = "other free form text" };

            it.ShouldNotBeNull();
            it.Location.ShouldEqual("other free form text");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Location cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByFreeformText_ShouldThrowException_WhenLocationIsNull()
        {
            new PlaceByFreeformText(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Location cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByFreeformText_ShouldThrowException_WhenLocationIsEmpty()
        {
            new PlaceByFreeformText(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Location cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByFreeformText_ShouldThrowException_WhenLocationIsWhiteSpace()
        {
            new PlaceByFreeformText("   ");
        }

    }
}

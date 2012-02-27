using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByWoeIdTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByWoeId_ShouldConstructWithWoeId()
        {
            var it = new PlaceByWoeId(1);

            it.ShouldNotBeNull();
            it.WoeId.ShouldEqual(1);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByWoeId_ShouldAllowWoeIdToBeChanged_AfterConstruction()
        {
            var it = new PlaceByWoeId(1) { WoeId = 2 };

            it.ShouldNotBeNull();
            it.WoeId.ShouldEqual(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "WoeId must be greater than zero.")]
        public void Yahoo_PlaceFinder_PlaceByWoeId_ShouldThrowException_WhenWoeIdIsLessThan1()
        {
            new PlaceByWoeId(0);
        }

    }
}

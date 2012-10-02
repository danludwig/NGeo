using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByMultilineAddressTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByMultilineAddress_ShouldConstructWithLine1()
        {
            var it = new PlaceByMultilineAddress("line 1");

            it.ShouldNotBeNull();
            it.Line1.ShouldEqual("line 1");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByMultilineAddress_ShouldAllowLinesToBeChanged_AfterConstruction()
        {
            var it = new PlaceByMultilineAddress("line 1", "line 2", "line 3")
            {
                Line1 = "other line 1",
                Line2 = "other line 2",
                Line3 = "other line 3",
            };

            it.ShouldNotBeNull();
            it.Line1.ShouldEqual("other line 1");
            it.Line2.ShouldEqual("other line 2");
            it.Line3.ShouldEqual("other line 3");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Line1 cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByMultilineAddress_ShouldThrowException_WhenLine1IsNull()
        {
            new PlaceByMultilineAddress(null).ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Location cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByMultilineAddress_ShouldThrowException_WhenLine1IsEmpty()
        {
            new PlaceByMultilineAddress(string.Empty).ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Location cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByMultilineAddress_ShouldThrowException_WhenFLine1IsWhiteSpace()
        {
            new PlaceByMultilineAddress("   ").ShouldBeNull();
        }

    }
}

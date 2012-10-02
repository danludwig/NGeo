using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByNameTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByName_ShouldConstructWithName()
        {
            var it = new PlaceByName("name");

            it.ShouldNotBeNull();
            it.Name.ShouldEqual("name");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByName_ShouldAllowNameToBeChanged_AfterConstruction()
        {
            var it = new PlaceByName("name") { Name = "other name" };

            it.ShouldNotBeNull();
            it.Name.ShouldEqual("other name");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByName_ShouldThrowException_WhenNameIsNull()
        {
            new PlaceByName(null).ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByName_ShouldThrowException_WhenNameIsEmpty()
        {
            new PlaceByName(string.Empty).ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Name cannot be null or whitespace.")]
        public void Yahoo_PlaceFinder_PlaceByName_ShouldThrowException_WhenNameIsWhiteSpace()
        {
            new PlaceByName("   ").ShouldBeNull();
        }

    }
}

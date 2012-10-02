using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Start must be between 0 and 99 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenStartIsGreaterThan99()
        {
            new PlaceByCoordinates(9.999, 8.888)
            {
                Start = 100,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Start must be between 0 and 99 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenStartLessThanZero()
        {
            new PlaceByFreeformText("text")
            {
                Start = -1,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveStart()
        {
            var request = new PlaceByWoeId(1)
            {
                Start = 9,
            };
            request.Start.ShouldEqual(9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Count must be between 0 and 100 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenCountIsGreaterThan100()
        {
            new PlaceByName("name")
            {
                Count = 101,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Count must be between 0 and 100 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenCountIsLessThanZero()
        {
            new PlaceByMultilineAddress("line 1")
            {
                Count = -1,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveCount()
        {
            var request = new PlaceByFullyParsedAddress
            {
                Count = 5,
            };
            request.Count.ShouldEqual(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Offset must be between 0 and 100 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenOffsetIsGreaterThan100()
        {
            new PlaceByCoordinates(4.6548, 8.56954)
            {
                Offset = 101,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Offset must be between 0 and 100 (inclusive).")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenOffsetIsLessThanZero()
        {
            new PlaceByFreeformText("text")
            {
                Offset = -1,
            }
            .ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveOffset()
        {
            var request = new PlaceByName("name")
            {
                Offset = 50,
            };
            request.Offset.ShouldEqual(50);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveFlags()
        {
            var request = new PlaceByWoeId(1);
            request.Flags.Add(Flag.Airport);
            request.Flags.ShouldContain(Flag.Airport);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldSerializeFlags()
        {
            var request = new PlaceByMultilineAddress("line 1");
            request.Flags.Add(Flag.Airport);
            request.Flags.Add(Flag.TelephoneAreaCode);
            var flags = request.GetFlagsAsString();
            flags.ShouldEqual("QR");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveGFlags()
        {
            var request = new PlaceByCoordinates(-12.9516, 159.1547);
            request.GFlags.Add(GFlag.QuickMode);
            request.GFlags.ShouldContain(GFlag.QuickMode);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldSerializeGFlags()
        {
            var request = new PlaceByFreeformText("text");
            request.GFlags.Add(GFlag.QuickMode);
            request.GFlags.Add(GFlag.LimitToLocaleCountry);
            var flags = request.GetGFlagsAsString();
            flags.ShouldEqual("QL");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Flags cannot be null.")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenFlagsIsNull()
        {
            new PlaceByName("name")
            {
                Flags = null,
            }.ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "GFlags cannot be null.")]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldThrowException_WhenGFlagsIsNull()
        {
            new PlaceByWoeId(10)
            {
                GFlags = null,
            }.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveLocale()
        {
            var it = new PlaceByMultilineAddress("line 1")
            {
                Locale = "locale"
            };

            it.ShouldNotBeNull();
            it.Locale.ShouldEqual("locale");
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceBy_ShouldPreserveAppId()
        {
            var it = new PlaceByFullyParsedAddress
            {
                AppId = "app id"
            };

            it.ShouldNotBeNull();
            it.AppId.ShouldEqual("app id");
        }

    }
}

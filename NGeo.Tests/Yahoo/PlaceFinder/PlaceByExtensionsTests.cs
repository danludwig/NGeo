using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class PlaceByExtensionsTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ReturnCoordinateDataOnly_ShouldAddCoordinateDataOnlyFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").ReturnCoordinateDataOnly();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.CoordinateDataOnly);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ReturnCoordinateDataOnly_ShouldRemoveCoordinateDataOnlyFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.CoordinateDataOnly }
            }
            .ReturnCoordinateDataOnly(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.CoordinateDataOnly);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ReturnCoordinateDataOnly_ShouldDoNothing_WhenArgIsFalse_AndCoordinateDataOnlyFlagIsNotPresent()
        {
            var it = new PlaceByFreeformText("text")
                .ReturnCoordinateDataOnly(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.CoordinateDataOnly);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ExcludeWoeId_ShouldAddNoWoeIdFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").ExcludeWoeId();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.NoWoeId);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ExcludeWoeId_ShouldRemoveNoWoeIdFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.NoWoeId }
            }
            .ExcludeWoeId(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.NoWoeId);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ReturnGlobalElements_ShouldAddGlobalFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").ReturnGlobalElements();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.Global);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_ReturnGlobalElements_ShouldRemoveGlobalFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.Global }
            }
            .ReturnGlobalElements(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.Global);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeAirportCode_ShouldAddAirportFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeAirportCode();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.Airport);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeAirportCode_ShouldRemoveAirportFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.Airport }
            }
            .IncludeAirportCode(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.Airport);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeTelephoneAreaCode_ShouldAddTelephoneAreaCodeFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeTelephoneAreaCode();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.TelephoneAreaCode);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeTelephoneAreaCode_ShouldRemoveTelephoneAreaCodeFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.TelephoneAreaCode }
            }
            .IncludeTelephoneAreaCode(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.TelephoneAreaCode);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeTimeZone_ShouldAddTimeZoneFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeTimeZone();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.TimeZone);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeTimeZone_ShouldRemoveTimeZoneFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.TimeZone }
            }
            .IncludeTimeZone(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.TimeZone);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeBoundingBox_ShouldAddBoundingBoxFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeBoundingBox();

            it.ShouldNotBeNull();
            it.Flags.ShouldContain(Flag.BoundingBox);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeBoundingBox_ShouldRemoveBoundingBoxFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                Flags = new HashSet<Flag> { Flag.BoundingBox }
            }
            .IncludeBoundingBox(false);

            it.ShouldNotBeNull();
            it.Flags.ShouldNotContain(Flag.BoundingBox);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeNeighborhoods_ShouldAddNeighborhoodsGFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeNeighborhoods();

            it.ShouldNotBeNull();
            it.GFlags.ShouldContain(GFlag.Neighborhoods);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeNeighborhoods_ShouldRemoveNeighborhoodsGFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                GFlags = new HashSet<GFlag> { GFlag.Neighborhoods }
            }
            .IncludeNeighborhoods(false);

            it.ShouldNotBeNull();
            it.GFlags.ShouldNotContain(GFlag.Neighborhoods);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeCrossStreets_ShouldAddCrossStreetsGFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").IncludeCrossStreets();

            it.ShouldNotBeNull();
            it.GFlags.ShouldContain(GFlag.CrossStreets);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_IncludeCrossStreets_ShouldRemoveCrossStreetsGFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                GFlags = new HashSet<GFlag> { GFlag.CrossStreets }
            }
            .IncludeCrossStreets(false);

            it.ShouldNotBeNull();
            it.GFlags.ShouldNotContain(GFlag.CrossStreets);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_LimitResultsToLocaleCountry_ShouldAddLimitToLocaleCountryGFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").LimitResultsToLocaleCountry();

            it.ShouldNotBeNull();
            it.GFlags.ShouldContain(GFlag.LimitToLocaleCountry);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_LimitResultsToLocaleCountry_ShouldRemoveLimitToLocaleCountryGFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                GFlags = new HashSet<GFlag> { GFlag.LimitToLocaleCountry }
            }
            .LimitResultsToLocaleCountry(false);

            it.ShouldNotBeNull();
            it.GFlags.ShouldNotContain(GFlag.LimitToLocaleCountry);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_QuickMode_ShouldAddQuickModeGFlag_WhenNoArgIsSpecified()
        {
            var it = new PlaceByFreeformText("text").QuickMode();

            it.ShouldNotBeNull();
            it.GFlags.ShouldContain(GFlag.QuickMode);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_PlaceByExtensions_QuickMode_ShouldRemoveQuickModeGFlag_WhenArgIsFalse()
        {
            var it = new PlaceByFreeformText("text")
            {
                GFlags = new HashSet<GFlag> { GFlag.QuickMode }
            }
            .QuickMode(false);

            it.ShouldNotBeNull();
            it.GFlags.ShouldNotContain(GFlag.QuickMode);
        }

    }
}

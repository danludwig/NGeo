using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class FlagTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_Flag_ShouldHave10Members()
        {
            ((int)Flag.CoordinateDataOnly).ShouldEqual(0);
            ((int)Flag.NoWoeId).ShouldEqual(1);
            ((int)Flag.Global).ShouldEqual(2);
            ((int)Flag.Json).ShouldEqual(3);
            ((int)Flag.Php).ShouldEqual(4);
            ((int)Flag.Airport).ShouldEqual(5);
            ((int)Flag.TelephoneAreaCode).ShouldEqual(6);
            ((int)Flag.StreetDetail).ShouldEqual(7);
            ((int)Flag.TimeZone).ShouldEqual(8);
            ((int)Flag.BoundingBox).ShouldEqual(9);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Flag_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(Flag), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_Flag_ShouldHaveEnumMemberAttributes()
        {
            var enumMembers = new Dictionary<Flag, string>
            {
                { Flag.CoordinateDataOnly, "C" },
                { Flag.NoWoeId, "E" },
                { Flag.Global, "G" },
                { Flag.Json, "J" },
                { Flag.Php, "P" },
                { Flag.Airport, "Q" },
                { Flag.TelephoneAreaCode, "R" },
                { Flag.StreetDetail, "S" },
                { Flag.TimeZone, "T" },
                { Flag.BoundingBox, "X" },
            };

            var values = Enum.GetValues(typeof(Flag)) as Flag[];
            values.ShouldNotBeNull();

            Debug.Assert(values != null);
            foreach (var value in values)
            {
                value.ShouldHaveEnumMemberAttribute(enumMembers[value]);
            }
        }

    }
}

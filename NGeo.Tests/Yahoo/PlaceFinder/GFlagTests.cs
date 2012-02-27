using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class GFlagTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_GFlag_ShouldHave10Members()
        {
            ((int)GFlag.Neighborhoods).ShouldEqual(0);
            ((int)GFlag.CrossStreets).ShouldEqual(1);
            ((int)GFlag.LimitToLocaleCountry).ShouldEqual(2);
            ((int)GFlag.QuickMode).ShouldEqual(3);
            ((int)GFlag.Reverse).ShouldEqual(4);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_GFlag_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(GFlag), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_GFlag_ShouldHaveEnumMemberAttributes()
        {
            var enumMembers = new Dictionary<GFlag, string>
            {
                { GFlag.Neighborhoods, "A" },
                { GFlag.CrossStreets, "C" },
                { GFlag.LimitToLocaleCountry, "L" },
                { GFlag.QuickMode, "Q" },
                { GFlag.Reverse, "R" },
            };

            var values = Enum.GetValues(typeof(GFlag)) as GFlag[];
            values.ShouldNotBeNull();

            Debug.Assert(values != null);
            foreach (var value in values)
            {
                value.ShouldHaveEnumMemberAttribute(enumMembers[value]);
            }
        }

    }
}

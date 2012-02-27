using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class ResultStyleTests
    {
        [TestMethod]
        public void GeoNames_ResultStyle_ShouldHave4Members()
        {
            ((int)ResultStyle.Short).ShouldEqual(0);
            ((int)ResultStyle.Medium).ShouldEqual(1);
            ((int)ResultStyle.Long).ShouldEqual(2);
            ((int)ResultStyle.Full).ShouldEqual(3);
        }

        [TestMethod]
        public void GeoNames_ResultStyle_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(ResultStyle), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_ResultStyle_ShouldHaveEnumMemberAttributes()
        {
            var enumMembers = new Dictionary<ResultStyle, string>
            {
                { ResultStyle.Short, "short" },
                { ResultStyle.Medium, "medium" },
                { ResultStyle.Long, "long" },
                { ResultStyle.Full, "full" },
            };

            var values = Enum.GetValues(typeof (ResultStyle)) as ResultStyle[];
            values.ShouldNotBeNull();

            Debug.Assert(values != null);
            foreach (var value in values)
            {
                value.ShouldHaveEnumMemberAttribute(enumMembers[value]);
            }
        }

    }
}

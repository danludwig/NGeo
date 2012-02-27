using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [TestClass]
    public class TimeZoneTests
    {
        [TestMethod]
        public void GeoNames_TimeZone_ShouldBePublic()
        {
            var model = new TimeZone
            {
                Id = "id",
                DstOffset = 1.0,
                GmtOffset = 2.0,
            };

            model.ShouldNotBeNull();
            model.Id.ShouldEqual("id");
            model.DstOffset.ShouldEqual(1.0);
            model.GmtOffset.ShouldEqual(2.0);
        }

        [TestMethod]
        public void GeoNames_TimeZone_ShouldOverrideToString()
        {
            var model = new TimeZone
            {
                Id = "id",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Id);
        }

        [TestMethod]
        public void GeoNames_TimeZone_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(TimeZone), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_TimeZone_Id_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<TimeZone, string>>>
            {
                { "timeZoneId", p => p.Id },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_TimeZone_OffsetProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<TimeZone, double>>>
            {
                { "dstOffset", p => p.DstOffset },
                { "gmtOffset", p => p.GmtOffset },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

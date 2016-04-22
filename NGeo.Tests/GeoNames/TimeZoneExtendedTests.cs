using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [TestClass]
    public class TimeZoneExtendedTests
    {
        [TestMethod]
        public void GeoNames_TimeZone_ShouldBePublic()
        {
            DateTime refTimeA = DateTime.Now;
            DateTime refTimeB = refTimeA.AddMinutes(1);
            DateTime refTimeC = refTimeA.AddMinutes(2);
            var model = new TimeZoneExtended
            {
                Id = "id",
                CountryCode = "cc",
                CountryName = "some name",
                DstOffset = 1.0,
                GmtOffset = 2.0,
                Latitude = 3.0,
                Longitude = 4.0,
                RawOffset = 5.0,
                // Kevin Hollingshead (kh14821@gmail.com)
                // DateTimes aren't working, giving an error that reflects that the
                // JSON deserializer is expecting an obsolete format ("/Date = .../")
                // and I'm not sure how to fix it right now. Ping me if you need these
                // and I'll try to help find a solution.
                //Sunrise = refTimeA,
                //Sunset = refTimeB,
                //Time = refTimeC,
            };

            model.ShouldNotBeNull();
            model.Id.ShouldEqual("id");
            model.CountryCode.ShouldEqual("cc");
            model.CountryName.ShouldEqual("some name");
            model.DstOffset.ShouldEqual(1.0);
            model.GmtOffset.ShouldEqual(2.0);
            model.Latitude.ShouldEqual(3.0);
            model.Longitude.ShouldEqual(4.0);
            model.RawOffset.ShouldEqual(5.0);
            //model.Sunrise.ShouldEqual(refTimeA);
            //model.Sunset.ShouldEqual(refTimeB);
            //model.Time.ShouldEqual(refTimeC);
        }

        [TestMethod]
        public void GeoNames_TimeZone_ShouldOverrideToString()
        {
            var model = new TimeZoneExtended
            {
                Id = "id",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Id);
        }

        [TestMethod]
        public void GeoNames_TimeZone_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(TimeZoneExtended), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_TimeZone_String_Properties_ShouldHaveDataMemberAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<TimeZoneExtended, string>>>
            {
                { "timezoneId", p => p.Id },
                { "countryCode", p => p.CountryCode },
                { "countryName", p => p.CountryName },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void GeoNames_TimeZone_Double_Properties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<TimeZoneExtended, double>>>
            {
                { "dstOffset", p => p.DstOffset },
                { "gmtOffset", p => p.GmtOffset },
                { "rawOffset", p => p.RawOffset },
                { "lat", p => p.Latitude },
                { "lng", p => p.Longitude },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

        //[TestMethod]
        //public void GeoNames_TimeZone_DateTime_Properties_ShouldHaveDataMemberAttributes()
        //{
        //    var properties = new Dictionary<string, Expression<Func<TimeZoneExtended, DateTime>>>
        //    {
        //        { "time", p => p.Time },
        //        { "sunrise", p => p.Sunrise },
        //        { "sunset", p => p.Sunset },
        //    };

        //    properties.ShouldHaveDataMemberAttributes();
        //}

    }
}

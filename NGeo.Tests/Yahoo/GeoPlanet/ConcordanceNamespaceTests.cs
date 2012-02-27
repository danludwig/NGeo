using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class ConcordanceNamespaceTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceNamespace_ShouldHave7Members()
        {
            ((int)ConcordanceNamespace.WoeId).ShouldEqual(0);
            ((int)ConcordanceNamespace.GeoNames).ShouldEqual(1);
            ((int)ConcordanceNamespace.Iso).ShouldEqual(2);
            ((int)ConcordanceNamespace.Fips10).ShouldEqual(3);
            ((int)ConcordanceNamespace.OpenStreetMapId).ShouldEqual(4);
            ((int)ConcordanceNamespace.WikipediaPageId).ShouldEqual(5);
            ((int)ConcordanceNamespace.IanaTld).ShouldEqual(6);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceNamespace_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(ConcordanceNamespace), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceNamespace_ShouldHaveEnumMemberAttributes()
        {
            var enumMembers = new Dictionary<ConcordanceNamespace, string>
            {
                { ConcordanceNamespace.WoeId, "woeid" },
                { ConcordanceNamespace.GeoNames, "geonames" },
                { ConcordanceNamespace.Iso, "iso" },
                { ConcordanceNamespace.Fips10, "fips10" },
                { ConcordanceNamespace.OpenStreetMapId, "osm" },
                { ConcordanceNamespace.WikipediaPageId, "wiki" },
                { ConcordanceNamespace.IanaTld, "cctld" },
            };

            var values = Enum.GetValues(typeof(ConcordanceNamespace)) as ConcordanceNamespace[];
            values.ShouldNotBeNull();

            Debug.Assert(values != null);
            foreach (var value in values)
            {
                value.ShouldHaveEnumMemberAttribute(enumMembers[value]);
            }
        }

    }
}

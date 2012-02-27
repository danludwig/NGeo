using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class ConcordanceResponseTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceResponse_ShouldBePublic()
        {
            var model = new ConcordanceResponse();
            model.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceResponse_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(ConcordanceResponse), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceResponse_StringProperties_ShouldHaveDataContractAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<ConcordanceResponse, string>>>
            {
                { "iso", p => p.Iso },
                { "fips10", p => p.Fips10 },
                { "cctld", p => p.IanaTld },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_ConcordanceResponse_IntProperties_ShouldHaveDataContractAttribute()
        {
            var properties = new Dictionary<string, Expression<Func<ConcordanceResponse, int>>>
            {
                { "woeid", p => p.WoeId },
                { "geonames", p => p.GeoNameId },
                { "osm", p => p.OpenStreetMapId },
                { "wiki", p => p.WikipediaPageId },
            };
            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

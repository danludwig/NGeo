using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class AlternateNameTests
    {
        [TestMethod]
        public void GeoNames_AlternateName_ShouldBePublic()
        {
            var model = new AlternateName
            {
                Name = "name",
                Language = "lang",
            };

            model.ShouldNotBeNull();
            model.Name.ShouldNotBeNull();
            model.Language.ShouldNotBeNull();
        }

        [TestMethod]
        public void GeoNames_AlternateName_ShouldOverrideToString()
        {
            var model = new AlternateName
            {
                Name = "name",
                Language = "lang",
            };

            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(string.Format("{0}:{1}", model.Language, model.Name));
        }

        [TestMethod]
        public void GeoNames_AlternateName_ShouldHaveDataContractAttribute()
        {
            Attribute.IsDefined(typeof(AlternateName), typeof(DataContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_AlternateName_StringProperties_ShouldHaveDataMemberAttributes()
        {
            var properties = new Dictionary<string, Expression<Func<AlternateName, string>>>
            {
                { "name", p => p.Name },
                { "lang", p => p.Language },
            };

            properties.ShouldHaveDataMemberAttributes();
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlaceTypeTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceType_ShouldBePublic()
        {
            var it = new PlaceType
            {
                Language = "language",
                Uri = new Uri("http://ngeo.codeplex.com"),
                Name = "name",
                Description = "description",
                Code = 6,
            };

            it.ShouldNotBeNull();
            it.Language.ShouldNotBeNull();
            it.Uri.ShouldNotBeNull();
            it.Name.ShouldNotBeNull();
            it.Description.ShouldNotBeNull();
            it.Code.ShouldEqual(6);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_PlaceType_ShouldOverrideToString()
        {
            var model = new PlaceType { Name = "name" };
            model.ShouldNotBeNull();
            model.ToString().ShouldEqual(model.Name);
        }

    }
}

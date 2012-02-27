using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class PlaceTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_Place_ShouldBePublic()
        {
            var it = new Place
            {
                WoeId = 4,
                Language = "language",
                Uri = new Uri("http://ngeo.codeplex.com"),
                Name = "name",
                Type = new PlaceType(),
                Country = new Admin(),
                Admin1 = new Admin(),
                Admin2 = new Admin(),
                Admin3 = new Admin(),
                Locality1 = new Locality(),
                Locality2 = new Locality(),
                Postal = "postal",
                AreaRank = 44,
                PopulationRank = 69,
                Center = new Point(),
                BoundingBox = new BoundingBox(),
            };

            it.ShouldNotBeNull();
            it.WoeId.ShouldEqual(4);
            it.Language.ShouldNotBeNull();
            it.Uri.ShouldNotBeNull();
            it.Name.ShouldNotBeNull();
            it.Type.ShouldNotBeNull();
            it.Country.ShouldNotBeNull();
            it.Admin1.ShouldNotBeNull();
            it.Admin2.ShouldNotBeNull();
            it.Admin3.ShouldNotBeNull();
            it.Locality1.ShouldNotBeNull();
            it.Locality2.ShouldNotBeNull();
            it.Postal.ShouldNotBeNull();
            it.AreaRank.ShouldEqual(44);
            it.PopulationRank.ShouldEqual(69);
            it.Center.ShouldNotBeNull();
            it.BoundingBox.ShouldNotBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Place_ShouldOverrideToString()
        {
            var it = new Place
            {
                Name = "place name",
                Type = new PlaceType { Name = "type name" }
            };

            it.ShouldNotBeNull();
            it.ToString().ShouldEqual("place name (type name)");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_Place_Postal_ShouldBeConvertedToNull_WhenEmptyOrWhiteSpace()
        {
            var it = new Place
            {
                Postal = "   ",
            };

            it.ShouldNotBeNull();
            it.Postal.ShouldBeNull();
        }

    }
}

using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class GeoPlanetClientTests
    {
        private static readonly string AppId = ConfigurationManager.AppSettings["GeoPlanetAppId"];

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Place_ShouldReturn1Result_ForWoeId2380358()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var place = geoPlanetClient.Place(2380358, AppId);

                place.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Place_ShouldReturnNull_When404ExceptionIsThrown()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var place = geoPlanetClient.Place(int.MaxValue, AppId);

                place.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Parent_ShouldReturn1Result_ForWoeId2380358()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var place = geoPlanetClient.Parent(2380358, AppId);

                place.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Parent_ShouldReturnNull_When404ExceptionIsThrown()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var place = geoPlanetClient.Parent(1, AppId);

                place.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Ancestors_ShouldReturnResults_ForWoeId2380358()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var places = geoPlanetClient.Ancestors(2380358, AppId);

                places.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Ancestors_ShouldReturnNull_When404ExceptionIsThrown()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var places = geoPlanetClient.Ancestors(23424802, AppId);

                places.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_BelongTos_ShouldReturnResults_ForWoeId2380358()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var places = geoPlanetClient.BelongTos(23424833, AppId, RequestView.Long);

                places.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_BelongTos_ShouldReturnNull_When404ExceptionIsThrown()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var places = geoPlanetClient.BelongTos(1, AppId);

                places.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Types_ShouldReturnResults()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var placeTypes = geoPlanetClient.Types(AppId);

                placeTypes.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Type_ShouldReturn1Result_ForType35()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var placeType = geoPlanetClient.Type(35, AppId, RequestView.Long);

                placeType.ShouldNotBeNull();
                placeType.Code.ShouldEqual(35);
                placeType.Name.ShouldNotBeNull();
                placeType.Description.ShouldNotBeNull();
                placeType.Uri.ShouldNotBeNull();
                placeType.Language.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Type_ShouldReturnNull_WhenTypeDoesNotExist()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var placeType = geoPlanetClient.Type(int.MaxValue, AppId, RequestView.Long);

                placeType.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Continents_ShouldReturn7Results()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var continents = geoPlanetClient.Continents(AppId);

                continents.ShouldNotBeNull();
                continents.Items.ShouldNotBeNull();
                continents.Items.Count.ShouldEqual(7);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Countries_ShouldReturnResults()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var countries = geoPlanetClient.Countries(AppId);

                countries.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_States_ShouldReturn32Results_ForWoeId23424781()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var states = geoPlanetClient.States(23424781, AppId);

                states.ShouldNotBeNull();
                states.Items.ShouldNotBeNull();
                states.Items.Count.ShouldEqual(32);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_States_ShouldReturnNull_ForWoeId28289409()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var states = geoPlanetClient.States(28289409, AppId);

                states.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Level1Admins_ShouldReturn13Results_ForWoeId23424775()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var level1Admins = geoPlanetClient.Level1Admins(23424775, AppId);

                level1Admins.ShouldNotBeNull();
                level1Admins.Items.ShouldNotBeNull();
                level1Admins.Items.Count.ShouldEqual(13);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Counties_ShouldReturn88Results_ForWoeId2347594()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var counties = geoPlanetClient.Counties(2347594, AppId);

                counties.ShouldNotBeNull();
                counties.Items.ShouldNotBeNull();
                counties.Items.Count.ShouldEqual(88);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_States_ShouldReturnNull_ForWoeId2514815()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var counties = geoPlanetClient.Counties(2514815, AppId);

                counties.ShouldBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Level2Admins_ShouldReturn58Results_ForWoeId2347563()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var level2Admins = geoPlanetClient.Level2Admins(2347563, AppId);

                level2Admins.ShouldNotBeNull();
                level2Admins.Items.ShouldNotBeNull();
                level2Admins.Items.Count.ShouldEqual(58);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Concordance_WithIntId_ShouldReturnResults()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var response = geoPlanetClient.Concordance(ConcordanceNamespace.WoeId, 2380358, AppId);

                response.ShouldNotBeNull();
                response.ForNamespace.ShouldEqual(ConcordanceNamespace.WoeId);
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Concordance_WithStringId_ShouldReturnResults()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var response = geoPlanetClient.Concordance(ConcordanceNamespace.Iso, "DE", AppId);

                response.ShouldNotBeNull();
            }
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_GeoPlanetClient_Concordance_ShouldReturnNull_When404ExceptionIsThrown()
        {
            using (var geoPlanetClient = new GeoPlanetClient())
            {
                var response = geoPlanetClient.Concordance(ConcordanceNamespace.GeoNames, 6295630, AppId);

                response.ShouldBeNull();
            }
        }

    }
}

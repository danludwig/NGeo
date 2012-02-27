using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using System;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    [TestClass]
    public class JsonConverterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldThrowException_WhenJsonPlaceIsNull()
        {
            var jsonPlaces = new List<JsonPlace> { new JsonPlace(), null, new JsonPlace(), };
            jsonPlaces[1].ToPlace();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaces_ShouldThrowException_WhenJsonPlacesIsNull()
        {
            var jsonPlaces = (DateTime.Now.Year > 2010) ? null : new List<JsonPlace>();
            jsonPlaces.ToPlaces();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAutosFromJson()
        {
            var json = new JsonPlace
            {
                WoeId = 72,
                Name = "name",
                Language = "language",
                Uri = new Uri("http://ngeo.codeplex.com"),
                Center = new Point { Latitude = 9.84, Longitude = 52.445, },
                BoundingBox = new BoundingBox
                {
                    Northeast = new Point { Latitude = 8.541, Longitude = 77.93, },
                    Southwest = new Point { Latitude = 4.362, Longitude = 129.63, },
                },
                AreaRank = 43,
                PopulationRank = 33,
                Postal = "postal",
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.WoeId.ShouldEqual(json.WoeId);
            model.Name.ShouldEqual(json.Name);
            model.Language.ShouldEqual(json.Language);
            model.Center.ShouldNotBeNull();
            model.Center.ShouldEqual(json.Center);
            model.Center.Latitude.ShouldEqual(json.Center.Latitude);
            model.Center.Longitude.ShouldEqual(json.Center.Longitude);
            model.BoundingBox.ShouldNotBeNull();
            model.BoundingBox.Northeast.ShouldNotBeNull();
            model.BoundingBox.Northeast.Latitude.ShouldEqual(json.BoundingBox.Northeast.Latitude);
            model.BoundingBox.Northeast.Longitude.ShouldEqual(json.BoundingBox.Northeast.Longitude);
            model.BoundingBox.Southwest.ShouldNotBeNull();
            model.BoundingBox.Southwest.Latitude.ShouldEqual(json.BoundingBox.Southwest.Latitude);
            model.BoundingBox.Southwest.Longitude.ShouldEqual(json.BoundingBox.Southwest.Longitude);
            model.AreaRank.ShouldEqual(json.AreaRank);
            model.PopulationRank.ShouldEqual(json.PopulationRank);
            model.Postal.ShouldEqual(json.Postal);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertTypeFromJson_WithNonNullTypeValues()
        {
            var json = new JsonPlace
            {
                TypeName = "type name",
                Type = new JsonPlaceTypeAttributes { Code = 11, },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Type.ShouldNotBeNull();
            model.Type.Name.ShouldEqual("type name");
            model.Type.Code.ShouldEqual(11);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertTypeFromJson_WithNullType()
        {
            var json = new JsonPlace
            {
                TypeName = "type name",
                Type = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Type.ShouldNotBeNull();
            model.Type.Name.ShouldEqual("type name");
            model.Type.Code.ShouldEqual(default(int));
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertCountryFromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                CountryName = "country name",
                Country = new JsonAdminAttributes
                {
                    Code = "country code",
                    Type = "country type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Country.ShouldNotBeNull();
            model.Country.Name.ShouldEqual("country name");
            model.Country.Code.ShouldEqual("country code");
            model.Country.Type.ShouldEqual("country type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertCountryFromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                CountryName = "country name",
                Country = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Country.ShouldNotBeNull();
            model.Country.Name.ShouldEqual("country name");
            model.Country.Code.ShouldBeNull();
            model.Country.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin1FromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                Admin1Name = "admin1 name",
                Admin1 = new JsonAdminAttributes
                {
                    Code = "admin1 code",
                    Type = "admin1 type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin1.ShouldNotBeNull();
            model.Admin1.Name.ShouldEqual("admin1 name");
            model.Admin1.Code.ShouldEqual("admin1 code");
            model.Admin1.Type.ShouldEqual("admin1 type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin1FromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                Admin1Name = "admin1 name",
                Admin1 = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin1.ShouldNotBeNull();
            model.Admin1.Name.ShouldEqual("admin1 name");
            model.Admin1.Code.ShouldBeNull();
            model.Admin1.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin2FromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                Admin2Name = "admin2 name",
                Admin2 = new JsonAdminAttributes
                {
                    Code = "admin2 code",
                    Type = "admin2 type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin2.ShouldNotBeNull();
            model.Admin2.Name.ShouldEqual("admin2 name");
            model.Admin2.Code.ShouldEqual("admin2 code");
            model.Admin2.Type.ShouldEqual("admin2 type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin2FromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                Admin2Name = "admin2 name",
                Admin2 = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin2.ShouldNotBeNull();
            model.Admin2.Name.ShouldEqual("admin2 name");
            model.Admin2.Code.ShouldBeNull();
            model.Admin2.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertLocality1FromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                Locality1Name = "locality1 name",
                Locality1 = new JsonLocalityAttributes
                {
                    Type = "locality1 type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Locality1.ShouldNotBeNull();
            model.Locality1.Name.ShouldEqual("locality1 name");
            model.Locality1.Type.ShouldEqual("locality1 type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertLocality1FromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                Locality1Name = "locality1 name",
                Locality1 = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Locality1.ShouldNotBeNull();
            model.Locality1.Name.ShouldEqual("locality1 name");
            model.Locality1.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertLocality2FromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                Locality2Name = "locality2 name",
                Locality2 = new JsonLocalityAttributes
                {
                    Type = "locality2 type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Locality2.ShouldNotBeNull();
            model.Locality2.Name.ShouldEqual("locality2 name");
            model.Locality2.Type.ShouldEqual("locality2 type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertLocality2FromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                Locality2Name = "locality2 name",
                Locality2 = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Locality2.ShouldNotBeNull();
            model.Locality2.Name.ShouldEqual("locality2 name");
            model.Locality2.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin3FromJson_WithNonNullValues()
        {
            var json = new JsonPlace
            {
                Admin3Name = "admin3 name",
                Admin3 = new JsonAdminAttributes
                {
                    Code = "admin3 code",
                    Type = "admin3 type"
                },
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin3.ShouldNotBeNull();
            model.Admin3.Name.ShouldEqual("admin3 name");
            model.Admin3.Code.ShouldEqual("admin3 code");
            model.Admin3.Type.ShouldEqual("admin3 type");
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlace_ShouldConvertAdmin3FromJson_WithNullCountry()
        {
            var json = new JsonPlace
            {
                Admin3Name = "admin3 name",
                Admin3 = null,
            };

            var model = json.ToPlace();

            model.ShouldNotBeNull();
            model.Admin3.ShouldNotBeNull();
            model.Admin3.Name.ShouldEqual("admin3 name");
            model.Admin3.Code.ShouldBeNull();
            model.Admin3.Type.ShouldBeNull();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaces_ShouldConvertTypeFromJson()
        {
            var jsons = new List<JsonPlace>
            {
                new JsonPlace
                {
                    TypeName = "type name",
                    Type = new JsonPlaceTypeAttributes { Code = 13, },
                },
            };

            var models = jsons.ToPlaces();

            models.ShouldNotBeNull();
            models.Count.ShouldEqual(1);
            models[0].Type.ShouldNotBeNull();
            models[0].Type.Name.ShouldEqual("type name");
            models[0].Type.Code.ShouldEqual(13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaceTypes_ShouldThrowException_WhenJsonPlaceTypeIsNull()
        {
            var jsons = new List<JsonPlaceType>
            {
                new JsonPlaceType(), null, new JsonPlaceType(),
            };

            jsons.ToPlaceTypes();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaceTypes_ShouldThrowException_WhenJsonPlaceTypesIsNull()
        {
            var jsons = (DateTime.Now.Year > 2010) ? null : new List<JsonPlaceType>();
            jsons.ToPlaceTypes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaceTypes_ShouldConvertAutosFromJson()
        {
            var jsons = new List<JsonPlaceType>
            {
                new JsonPlaceType
                {
                    Name = "name",
                    Language = "language",
                    Uri = new Uri("http://ngeo.codeplex.com"),
                    Description = "description",
                },
            };

            var models = jsons.ToPlaceTypes();

            models.ShouldNotBeNull();
            models.Count.ShouldEqual(1);
            models[0].Name.ShouldEqual(jsons[0].Name);
            models[0].Language.ShouldEqual(jsons[0].Language);
            models[0].Uri.ShouldEqual(jsons[0].Uri);
            models[0].Description.ShouldEqual(jsons[0].Description);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_JsonConverter_ToPlaceTypes_ShouldConvertCodeFromJson()
        {
            var jsons = new List<JsonPlaceType>
            {
                new JsonPlaceType
                {
                    JsonAttributes = new JsonPlaceTypeAttributes { Code = 66 },
                },
            };

            var models = jsons.ToPlaceTypes();

            models.ShouldNotBeNull();
            models.Count.ShouldEqual(1);
            models[0].Code.ShouldEqual(66);
        }

    }
}

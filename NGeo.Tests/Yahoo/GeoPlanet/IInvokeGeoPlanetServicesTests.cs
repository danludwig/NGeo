using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.GeoPlanet
{
    [TestClass]
    public class InvokeGeoPlanetServicesTests
    {
        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_ShouldHaveServiceContractAttribute()
        {
            Attribute.IsDefined(typeof(IInvokeGeoPlanetServices), typeof(ServiceContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_ShouldHaveOperationContractAttributes()
        {
            var placeResponseOperations = new Dictionary<string, Expression<Func<IInvokeGeoPlanetServices, PlaceResponse>>>
            {
                { "place", p => p.Place(default(string), default(string), default(RequestView)) },
                { "parent", p => p.Parent(default(string), default(string), default(RequestView)) },
            };

            var placesResponseOperations = new Dictionary<string, Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>>>
            {
                { "places", p => p.Places(default(string), default(string), default(RequestView)) },
                { "ancestors", p => p.Ancestors(default(string), default(string), default(RequestView)) },
                { "belongtos", p => p.BelongTos(default(string), default(string), default(RequestView)) },
                { "countries", p => p.Countries(default(string), default(RequestView)) },
                { "continents", p => p.Continents(default(string), default(RequestView)) },
                { "states", p => p.States(default(string), default(string), default(RequestView)) },
                { "counties", p => p.Counties(default(string), default(string), default(RequestView)) },
            };

            var placeTypesResponseOperations = new Dictionary<string, Expression<Func<IInvokeGeoPlanetServices, PlaceTypesResponse>>>
            {
                { "placetypes", p => p.Types(default(string), default(RequestView)) },
            };

            var concordanceResponseOperations = new Dictionary<string, Expression<Func<IInvokeGeoPlanetServices, ConcordanceResponse>>>
            {
                { "concordance", p => p.Concordance(default(string), default(string), default(string)) },
            };

            placeResponseOperations.ShouldHaveOperationContractAttributes();
            placesResponseOperations.ShouldHaveOperationContractAttributes();
            placeTypesResponseOperations.ShouldHaveOperationContractAttributes();
            concordanceResponseOperations.ShouldHaveOperationContractAttributes();
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Place_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlaceResponse>> method = p => p.Place(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlaceResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("place/{woeId}?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Places_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.Places(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("places.q({query});count=0?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Parent_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlaceResponse>> method = p => p.Parent(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlaceResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("place/{woeId}/parent?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Ancestors_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.Ancestors(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("place/{woeId}/ancestors?format=json&view={view}&count=0&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_BelongTos_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.BelongTos(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("place/{woeId}/belongtos?format=json&view={view}&count=0&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Types_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlaceTypesResponse>> method = p => p.Types(default(string),
                default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlaceTypesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("placetypes?format=json&view={view}&count=0&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Continents_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.Continents(default(string),
                default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("continents?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Countries_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.Countries(default(string),
                default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("countries?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_States_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.States(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("states/{country}?format=json&view={view}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Counties_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, PlacesResponse>> method = p => p.Counties(default(string),
                default(string), default(RequestView));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, PlacesResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("counties/{state}?format=json&view={view}&count=0&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_GeoPlanet_IInvokeGeoPlanetServices_Concordance_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoPlanetServices, ConcordanceResponse>> method = p => p.Concordance(default(string),
                default(string), default(string));
            var attributes = method.GetAttributes<IInvokeGeoPlanetServices, ConcordanceResponse, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("concordance/{nameSpace}/{id}?format=json&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

    }
}

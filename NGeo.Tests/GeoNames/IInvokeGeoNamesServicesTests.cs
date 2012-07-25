using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class InvokeGeoNamesServicesTests
    {
        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_ShouldHaveServiceContractAttribute()
        {
            Attribute.IsDefined(typeof(IInvokeGeoNamesServices), typeof(ServiceContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_ShouldHaveOperationContractAttributes()
        {
            var toponymResultsOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, Results<Toponym>>>>
            {
                { "findNearbyPlaceNameJSON0", p => p.FindNearbyPlaceName(default(double), default(double), default(string), 
                    default(double), default(int), default(ResultStyle), default(string)) },
                { "findNearbyPlaceNameJSON1", p => p.FindNearbyPlaceName(default(double), default(double), default(string), 
                    default(int), default(ResultStyle), default(string)) },
                { "childrenJSON", p => p.Children(default(int), default(string), default(ResultStyle), default(int)) },
            };

            var toponymOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, Toponym>>>
            {
                { "getJSON", p => p.Get(default(int), default(string)) },
            };

            var codeResultsOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, PostalCodeResults>>>
            {
                { "postalCodeLookupJSON", p => p.LookupPostalCode(default(string), default(string), default(int),
                    default(ResultStyle), default(string)) },
            };

            var countryResultsOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, Results<Country>>>>
            {
                { "countryInfoJSON", p => p.Countries(default(string)) },
            };

            var postalCodedCountryResultsOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, Results<PostalCodedCountry>>>>
            {
                { "postalCodeCountryInfoJSON", p => p.PostalCodeCountryInfo(default(string)) },
            };

            var hierarchyOperations = new Dictionary<string, Expression<Func<IInvokeGeoNamesServices, Hierarchy>>>
            {
                { "hierarchyJSON", p => p.Hierarchy(default(int), default(string), default(ResultStyle)) },
            };

            toponymResultsOperations.ShouldHaveOperationContractAttributes();
            toponymOperations.ShouldHaveOperationContractAttributes();
            codeResultsOperations.ShouldHaveOperationContractAttributes();
            countryResultsOperations.ShouldHaveOperationContractAttributes();
            postalCodedCountryResultsOperations.ShouldHaveOperationContractAttributes();
            hierarchyOperations.ShouldHaveOperationContractAttributes();
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_FindNearbyPlaceName_WithRadiusParameter_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Results<Toponym>>> method = p => p.FindNearbyPlaceName(
                default(double), default(double), default(string), default(double), default(int), default(ResultStyle), default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Results<Toponym>, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("findNearbyPlaceNameJSON?lat={latitude}&lng={longitude}&lang={language}"
                + "&radius={radiusInKm}&maxRows={maximumResults}&style={resultStyle}&username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_FindNearbyPlaceName_WithoutRadiusParameter_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Results<Toponym>>> method = p => p.FindNearbyPlaceName(
                default(double), default(double), default(string), default(int), default(ResultStyle), default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Results<Toponym>, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("findNearbyPlaceNameJSON?lat={latitude}&lng={longitude}&lang={language}"
                + "&maxRows={maximumResults}&style={resultStyle}&username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_LookupPostalCode_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, PostalCodeResults>> method = p => p.LookupPostalCode(
                default(string), default(string), default(int), default(ResultStyle), default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, PostalCodeResults, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("postalCodeLookupJSON?postalcode={postalcode}&country={country}"
                + "&maxRows={maximumResults}&style={resultStyle}&username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_PostalCodeCountryInfo_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Results<PostalCodedCountry>>> method = p =>
                p.PostalCodeCountryInfo(default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Results<PostalCodedCountry>, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("postalCodeCountryInfoJSON?username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_Get_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Toponym>> method = p => p.Get(
                default(int), default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Toponym, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("getJSON?geonameId={geoNameId}&username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_Children_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Results<Toponym>>> method = p => p.Children(
                default(int), default(string), default(ResultStyle), default(int));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Results<Toponym>, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual(
                "childrenJSON?geonameId={geoNameId}&style={resultStyle}&maxRows={maxRows}&username={userName}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_Countries_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Results<Country>>> method = p => p.Countries(
                default(string));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Results<Country>, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual(
                "countryInfoJSON?username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void GeoNames_IInvokeGeoNamesServices_Hierarchy_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokeGeoNamesServices, Hierarchy>> method = p => p.Hierarchy(
                default(int), default(string), default(ResultStyle));
            var attributes = method.GetAttributes<IInvokeGeoNamesServices, Hierarchy, WebInvokeAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual(
                "hierarchyJSON?geonameId={geoNameId}&style={resultStyle}&username={userName}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

    }
}

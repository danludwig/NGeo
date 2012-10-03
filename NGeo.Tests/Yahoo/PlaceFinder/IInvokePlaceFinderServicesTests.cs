using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.Yahoo.PlaceFinder
{
    [TestClass]
    public class InvokePlaceFinderServicesTests
    {
        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_ShouldHaveServiceContractAttribute()
        {
            Attribute.IsDefined(typeof(IInvokePlaceFinderServices), typeof(ServiceContractAttribute))
                .ShouldBeTrue();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_ShouldHaveOperationContractAttributes()
        {
            var operations = new Dictionary<string, Expression<Func<IInvokePlaceFinderServices, Response>>>
            {
                { "coordinates", p => p.FindByCoordinates(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "freeform", p => p.FindByFreeformText(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "name", p => p.FindByName(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "woeId", p => p.FindByWoeId(default(int), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "multiline", p => p.FindByMultilineAddress(default(string), default(string), default(string),
                    default(string), default(int), default(int), default(int), default(string), default(string), default(string)) },
                { "fullyParsed", p => p.FindByFullyParsedAddress(default(string), default(string), default(string),
                    default(string), default(string), default(string), default(string), default(string), default(string),
                    default(string), default(string), default(string), default(int), default(int), default(int),
                    default(string), default(string), default(string)) },
            };

            operations.ShouldHaveOperationContractAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByCoordinates_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByCoordinates(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?q={location}&locale={locale}&start={firstIndex}&count={maximumResults}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByFreeformText_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByFreeformText(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?q={location}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByName_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByName(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?name={name}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByWoeId_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByWoeId(default(int),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?woeid={woeId}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByMultilineAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByMultilineAddress(default(string),
                default(string), default(string), default(string), default(int), default(int), default(int), default(string),
                default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?line1={line1}&line2={line2}&line3={line3}" +
                "&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindByFullyParsedAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindByFullyParsedAddress(default(string),
                default(string), default(string), default(string), default(string), default(string), default(string),
                default(string), default(string), default(string), default(string), default(string), default(int),
                default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?house={house}&street={street}&unittype={unitType}&unit={unit}" +
                "&xstreet={crossStreet}&postal={postal}&neighborhood={neighborhood}&city={city}&county={county}" +
                "&state={state}&country={country}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }
    }
}

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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_ShouldHaveOperationContractAttributes_ForSingleResponses()
        {
            var operations = new Dictionary<string, Expression<Func<IInvokePlaceFinderServices, Response>>>
            {
                { "coordinates", p => p.FindOneByCoordinates(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "freeform", p => p.FindOneByFreeformText(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "name", p => p.FindOneByName(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "woeId", p => p.FindOneByWoeId(default(int), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "multiline", p => p.FindOneByMultilineAddress(default(string), default(string), default(string),
                    default(string), default(int), default(int), default(int), default(string), default(string), default(string)) },
                { "fullyParsed", p => p.FindOneByFullyParsedAddress(default(string), default(string), default(string),
                    default(string), default(string), default(string), default(string), default(string), default(string),
                    default(string), default(string), default(string), default(int), default(int), default(int),
                    default(string), default(string), default(string)) },
            };

            operations.ShouldHaveOperationContractAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_ShouldHaveOperationContractAttributes_ForManyResponses()
        {
            var operations = new Dictionary<string, Expression<Func<IInvokePlaceFinderServices, Response2>>>
            {
                { "coordinates2", p => p.FindManyByCoordinates(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "freeform2", p => p.FindManyByFreeformText(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "name2", p => p.FindManyByName(default(string), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "woeId2", p => p.FindManyByWoeId(default(int), default(string), default(int),
                    default(int), default(int), default(string), default(string), default(string)) },
                { "multiline2", p => p.FindManyByMultilineAddress(default(string), default(string), default(string),
                    default(string), default(int), default(int), default(int), default(string), default(string), default(string)) },
                { "fullyParsed2", p => p.FindManyByFullyParsedAddress(default(string), default(string), default(string),
                    default(string), default(string), default(string), default(string), default(string), default(string),
                    default(string), default(string), default(string), default(int), default(int), default(int),
                    default(string), default(string), default(string)) },
            };

            operations.ShouldHaveOperationContractAttributes();
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByCoordinates_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByCoordinates(default(string),
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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByCoordinates_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByCoordinates(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?q={location}&locale={locale}&start={firstIndex}&count={maximumResults}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].RequestFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByFreeformText_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByFreeformText(default(string),
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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByFreeformText_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByFreeformText(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?q={location}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByName_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByName(default(string),
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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByName_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByName(default(string),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?name={name}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByWoeId_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByWoeId(default(int),
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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByWoeId_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByWoeId(default(int),
                default(string), default(int), default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

            attributes.ShouldNotBeNull();
            attributes.Length.ShouldEqual(1);
            attributes[0].UriTemplate.ShouldEqual("geocode?woeid={woeId}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}");
            attributes[0].ResponseFormat.ShouldEqual(WebMessageFormat.Json);
            attributes[0].BodyStyle.ShouldEqual(WebMessageBodyStyle.Bare);
        }

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByMultilineAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByMultilineAddress(default(string),
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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByMultilineAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByMultilineAddress(default(string),
                default(string), default(string), default(string), default(int), default(int), default(int), default(string),
                default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

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
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindOneByFullyParsedAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response>> method = p => p.FindOneByFullyParsedAddress(default(string),
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

        [TestMethod]
        public void Yahoo_PlaceFinder_IInvokePlaceFinderServices_FindManyByFullyParsedAddress_ShouldHaveWebInvokeAttribute()
        {
            Expression<Func<IInvokePlaceFinderServices, Response2>> method = p => p.FindManyByFullyParsedAddress(default(string),
                default(string), default(string), default(string), default(string), default(string), default(string),
                default(string), default(string), default(string), default(string), default(string), default(int),
                default(int), default(int), default(string), default(string), default(string));
            var attributes = method.GetAttributes<IInvokePlaceFinderServices, Response2, WebGetAttribute>();

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

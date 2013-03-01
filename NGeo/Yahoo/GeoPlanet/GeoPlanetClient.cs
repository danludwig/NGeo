using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using NGeo.Yahoo.GeoPlanet.Json;
using System.Net;

namespace NGeo.Yahoo.GeoPlanet
{
    public sealed class GeoPlanetClient : ClientBase<IInvokeGeoPlanetServices>, IConsumeGeoPlanet
    {
        private const int RetryLimit = 5;
        private const string XmlDeserializeMessage = "Unable to deserialize XML body";

        public Place Place(int woeId, string appId, RequestView view = RequestView.Long)
        {
            try
            {
                var response = ChannelPlace(woeId, appId, view);
                return response.Result.ToPlace();
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlaceResponse ChannelPlace(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Place(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelPlace(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelPlace(woeId, appId, view, ++retry);
                throw;
            }
        }

        public Places Places(string query, string appId, RequestView view = RequestView.Long)
        {
            try
            {
                var response = ChannelPlaces(query, appId, view);
                var results = response.Results;
                if (results != null)
                    results.Items = new ReadOnlyCollection<Place>(
                        results.JsonItems != null
                            ? results.JsonItems.ToPlaces()
                            : new List<Place>()
                    );
                return results;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        private PlacesResponse ChannelPlaces(string query, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Places(query, appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelPlaces(query, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelPlaces(query, appId, view, ++retry);
                throw;
            }
        }

        public Place Parent(int woeId, string appId, RequestView view = RequestView.Long)
        {
            try
            {
                var response = ChannelParent(woeId, appId, view);
                return response.Result.ToPlace();
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlaceResponse ChannelParent(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Parent(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelParent(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelParent(woeId, appId, view, ++retry);
                throw;
            }
        }

        public Places Ancestors(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = ChannelAncestors(woeId, appId, view);
                var results = response.Results;
                if (results != null)
                    results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
                return results;
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlacesResponse ChannelAncestors(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Ancestors(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelAncestors(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelAncestors(woeId, appId, view, ++retry);
                throw;
            }
        }

        public Places BelongTos(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = ChannelBelongTos(woeId, appId, view);
                var results = response.Results;
                if (results != null)
                    results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
                return results;
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlacesResponse ChannelBelongTos(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.BelongTos(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelBelongTos(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelBelongTos(woeId, appId, view, ++retry);
                throw;
            }
        }

        public PlaceTypes Types(string appId, RequestView view = RequestView.Long)
        {
            var response = ChannelTypes(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<PlaceType>(results.JsonItems.ToPlaceTypes());
            return results;
        }

        private PlaceTypesResponse ChannelTypes(string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Types(appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelTypes(appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelTypes(appId, view, ++retry);
                throw;
            }
        }

        public PlaceType Type(int typeCode, string appId, RequestView view = RequestView.Short)
        {
            var types = Types(appId, view);
            return types.Items.SingleOrDefault(t => t.Code == typeCode);
        }

        public Places Continents(string appId, RequestView view = RequestView.Short)
        {
            var response = ChannelContinents(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
            return results;
        }

        private PlacesResponse ChannelContinents(string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Continents(appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelContinents(appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelContinents(appId, view, ++retry);
                throw;
            }
        }

        public Places Countries(string appId, RequestView view = RequestView.Short)
        {
            var response = ChannelCountries(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
            return results;
        }

        private PlacesResponse ChannelCountries(string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Countries(appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelCountries(appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelCountries(appId, view, ++retry);
                throw;
            }
        }

        public Places States(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = ChannelStates(woeId, appId, view);
                var results = response.Results;
                if (results != null)
                    results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
                return results;
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlacesResponse ChannelStates(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.States(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelStates(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelStates(woeId, appId, view, ++retry);
                throw;
            }
        }

        public Places Level1Admins(int woeId, string appId, RequestView view = RequestView.Short)
        {
            return States(woeId, appId, view);
        }

        public Places Counties(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = ChannelCounties(woeId, appId, view);
                var results = response.Results;
                if (results != null)
                    results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
                return results;
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        private PlacesResponse ChannelCounties(int woeId, string appId, RequestView view, int retry = 0)
        {
            try
            {
                return Channel.Counties(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelCounties(woeId, appId, view, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelCounties(woeId, appId, view, ++retry);
                throw;
            }
        }

        public Places Level2Admins(int woeId, string appId, RequestView view = RequestView.Short)
        {
            return Counties(woeId, appId, view);
        }

        public ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, string id, string appId)
        {
            try
            {
                var response = ChannelConcordance(nameSpace, id, appId);
                response.ForNamespace = nameSpace;
                return response;
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        public ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, int id, string appId)
        {
            return Concordance(nameSpace, id.ToString(CultureInfo.InvariantCulture), appId);
        }

        private ConcordanceResponse ChannelConcordance(ConcordanceNamespace nameSpace, string id, string appId, int retry = 0)
        {
            try
            {
                return Channel.Concordance(nameSpace.GetEnumMemberAttribute().Value, id, appId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelConcordance(nameSpace, id, appId, ++retry);
                throw;
            }
            catch (SerializationException ex)
            {
                if (retry < RetryLimit && ex.Message.StartsWith(XmlDeserializeMessage, StringComparison.Ordinal))
                    return ChannelConcordance(nameSpace, id, appId, ++retry);
                throw;
            }
        }
    }
}

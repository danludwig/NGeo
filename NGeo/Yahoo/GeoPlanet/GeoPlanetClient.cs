using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using NGeo.Yahoo.GeoPlanet.Json;

namespace NGeo.Yahoo.GeoPlanet
{
    public sealed class GeoPlanetClient : ClientBase<IInvokeGeoPlanetServices>, IConsumeGeoPlanet
    {
        public Place Place(int woeId, string appId, RequestView view = RequestView.Long)
        {
            try
            {
                var response = Channel.Place(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
                return response.Result.ToPlace();
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        public Place Parent(int woeId, string appId, RequestView view = RequestView.Long)
        {
            try
            {
                var response = Channel.Parent(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
                return response.Result.ToPlace();
            }
            catch (EndpointNotFoundException)
            {
                return null;
            }
        }

        public Places Ancestors(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = Channel.Ancestors(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
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

        public Places BelongTos(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = Channel.BelongTos(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
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

        public PlaceTypes Types(string appId, RequestView view = RequestView.Long)
        {
            var response = Channel.Types(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<PlaceType>(results.JsonItems.ToPlaceTypes());
            return results;
        }

        public PlaceType Type(int typeCode, string appId, RequestView view = RequestView.Short)
        {
            var types = Types(appId, view);
            return types.Items.SingleOrDefault(t => t.Code == typeCode);
        }

        public Places Continents(string appId, RequestView view = RequestView.Short)
        {
            var response = Channel.Continents(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
            return results;
        }

        public Places Countries(string appId, RequestView view = RequestView.Short)
        {
            var response = Channel.Countries(appId, view);
            var results = response.Results;
            if (results != null)
                results.Items = new ReadOnlyCollection<Place>(results.JsonItems.ToPlaces());
            return results;
        }

        public Places States(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = Channel.States(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
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

        public Places Level1Admins(int woeId, string appId, RequestView view = RequestView.Short)
        {
            return States(woeId, appId, view);
        }

        public Places Counties(int woeId, string appId, RequestView view = RequestView.Short)
        {
            try
            {
                var response = Channel.Counties(woeId.ToString(CultureInfo.InvariantCulture), appId, view);
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

        public Places Level2Admins(int woeId, string appId, RequestView view = RequestView.Short)
        {
            return Counties(woeId, appId, view);
        }

        public ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, string id, string appId)
        {
            try
            {
                var response = Channel.Concordance(nameSpace.GetEnumMemberAttribute().Value, id, appId);
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

    }
}

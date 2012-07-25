namespace NGeo.Yahoo.GeoPlanet
{
    public sealed class GeoPlanetContainer : IContainGeoPlanet
    {
        private readonly string _appId;
        private readonly IConsumeGeoPlanet _client;

        public GeoPlanetContainer(string appId)
        {
            _appId = appId;
            _client = new GeoPlanetClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public Place Place(int woeId, RequestView view = RequestView.Long)
        {
            return _client.Place(woeId, _appId, view);
        }

        public Places Places(string query, RequestView view = RequestView.Long)
        {
            return _client.Places(query, _appId, view);
        }

        public Place Parent(int woeId, RequestView view = RequestView.Long)
        {
            return _client.Parent(woeId, _appId, view);
        }

        public Places Ancestors(int woeId, RequestView view = RequestView.Short)
        {
            return _client.Ancestors(woeId, _appId, view);
        }

        public Places BelongTos(int woeId, RequestView view = RequestView.Short)
        {
            return _client.BelongTos(woeId, _appId, view);
        }

        public PlaceTypes Types(RequestView view = RequestView.Long)
        {
            return _client.Types(_appId, view);
        }

        public PlaceType Type(int typeCode, RequestView view = RequestView.Short)
        {
            return _client.Type(typeCode, _appId, view);
        }

        public Places Continents(RequestView view = RequestView.Short)
        {
            return _client.Continents(_appId, view);
        }

        public Places Countries(RequestView view = RequestView.Short)
        {
            return _client.Countries(_appId, view);
        }

        public Places States(int woeId, RequestView view = RequestView.Short)
        {
            return _client.States(woeId, _appId, view);
        }

        public Places Level1Admins(int woeId, RequestView view = RequestView.Short)
        {
            return _client.Level1Admins(woeId, _appId, view);
        }

        public Places Counties(int woeId, RequestView view = RequestView.Short)
        {
            return _client.Counties(woeId, _appId, view);
        }

        public Places Level2Admins(int woeId, RequestView view = RequestView.Short)
        {
            return _client.Level2Admins(woeId, _appId, view);
        }

        public ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, string id)
        {
            return _client.Concordance(nameSpace, id, _appId);
        }

        public ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, int id)
        {
            return _client.Concordance(nameSpace, id, _appId);
        }
    }
}

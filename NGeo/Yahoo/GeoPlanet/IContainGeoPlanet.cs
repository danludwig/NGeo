namespace NGeo.Yahoo.GeoPlanet
{
    public interface IContainGeoPlanet
    {
        Place Place(int woeId, RequestView view = RequestView.Long);

        Places Places(string query, RequestView view = RequestView.Long);

        Place Parent(int woeId, RequestView view = RequestView.Long);

        Places Ancestors(int woeId, RequestView view = RequestView.Short);

        Places BelongTos(int woeId, RequestView view = RequestView.Short);

        PlaceTypes Types(RequestView view = RequestView.Long);

        PlaceType Type(int typeCode, RequestView view = RequestView.Short);

        Places Continents(RequestView view = RequestView.Short);

        Places Countries(RequestView view = RequestView.Short);

        Places States(int woeId, RequestView view = RequestView.Short);

        Places Level1Admins(int woeId, RequestView view = RequestView.Short);

        Places Counties(int woeId, RequestView view = RequestView.Short);

        Places Level2Admins(int woeId, RequestView view = RequestView.Short);

        ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, string id);

        ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, int id);
    }
}
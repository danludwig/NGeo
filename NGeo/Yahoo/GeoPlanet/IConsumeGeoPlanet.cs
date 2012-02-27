using System;

namespace NGeo.Yahoo.GeoPlanet
{
    public interface IConsumeGeoPlanet : IDisposable
    {
        Place Place(int woeId, string appId, RequestView view = RequestView.Long);

        Place Parent(int woeId, string appId, RequestView view = RequestView.Long);

        Places Ancestors(int woeId, string appId, RequestView view = RequestView.Short);

        Places BelongTos(int woeId, string appId, RequestView view = RequestView.Short);

        PlaceTypes Types(string appId, RequestView view = RequestView.Long);

        PlaceType Type(int typeCode, string appId, RequestView view = RequestView.Short);

        Places Continents(string appId, RequestView view = RequestView.Short);

        Places Countries(string appId, RequestView view = RequestView.Short);

        Places States(int woeId, string appId, RequestView view = RequestView.Short);

        Places Level1Admins(int woeId, string appId, RequestView view = RequestView.Short);

        Places Counties(int woeId, string appId, RequestView view = RequestView.Short);

        Places Level2Admins(int woeId, string appId, RequestView view = RequestView.Short);

        ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, string id, string appId);

        ConcordanceResponse Concordance(ConcordanceNamespace nameSpace, int id, string appId);


    }
}

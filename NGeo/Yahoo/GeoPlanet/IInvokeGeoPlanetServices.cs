using System.ServiceModel;
using System.ServiceModel.Web;

namespace NGeo.Yahoo.GeoPlanet
{
    [ServiceContract]
    public interface IInvokeGeoPlanetServices
    {
        [OperationContract(Name = "place")]
        [WebGet(
            UriTemplate = "place/{woeId}?format=json&view={view}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlaceResponse Place(string woeId, string appId, RequestView view);

        [OperationContract(Name = "parent")]
        [WebGet(
            UriTemplate = "place/{woeId}/parent?format=json&view={view}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlaceResponse Parent(string woeId, string appId, RequestView view);

        [OperationContract(Name = "ancestors")]
        [WebGet(
            UriTemplate = "place/{woeId}/ancestors?format=json&view={view}&count=0&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse Ancestors(string woeId, string appId, RequestView view);

        [OperationContract(Name = "belongtos")]
        [WebGet(
            UriTemplate = "place/{woeId}/belongtos?format=json&view={view}&count=0&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse BelongTos(string woeId, string appId, RequestView view);

        [OperationContract(Name = "placetypes")]
        [WebGet(
            UriTemplate = "placetypes?format=json&view={view}&count=0&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlaceTypesResponse Types(string appId, RequestView view);

        [OperationContract(Name = "continents")]
        [WebGet(
            UriTemplate = "continents?format=json&view={view}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse Continents(string appId, RequestView view);

        [OperationContract(Name = "countries")]
        [WebGet(
            UriTemplate = "countries?format=json&view={view}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse Countries(string appId, RequestView view);

        [OperationContract(Name = "states")]
        [WebGet(
            UriTemplate = "states/{country}?format=json&view={view}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse States(string country, string appId, RequestView view);

        [OperationContract(Name = "counties")]
        [WebGet(
            UriTemplate = "counties/{state}?format=json&view={view}&count=0&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PlacesResponse Counties(string state, string appId, RequestView view);

        [OperationContract(Name = "concordance")]
        [WebGet(
            UriTemplate = "concordance/{nameSpace}/{id}?format=json&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        ConcordanceResponse Concordance(string nameSpace, string id, string appId);

    }
}

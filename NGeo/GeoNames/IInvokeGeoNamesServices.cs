using System.ServiceModel;
using System.ServiceModel.Web;

namespace NGeo.GeoNames
{
    [ServiceContract]
    public interface IInvokeGeoNamesServices
    {
        [OperationContract(Name = "findNearbyPlaceNameJSON0")]
        [WebInvoke(
            UriTemplate = "findNearbyPlaceNameJSON?lat={latitude}&lng={longitude}&lang={language}"
                + "&radius={radiusInKm}&maxRows={maximumResults}&style={resultStyle}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Results<Toponym> FindNearbyPlaceName(double latitude, double longitude, string language,
            double radiusInKm, int maximumResults, ResultStyle resultStyle, string userName);

        [OperationContract(Name = "findNearbyPlaceNameJSON1")]
        [WebInvoke(
            UriTemplate = "findNearbyPlaceNameJSON?lat={latitude}&lng={longitude}&lang={language}"
                + "&maxRows={maximumResults}&style={resultStyle}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Results<Toponym> FindNearbyPlaceName(double latitude, double longitude, string language,
            int maximumResults, ResultStyle resultStyle, string userName);

        [OperationContract(Name = "postalCodeLookupJSON")]
        [WebInvoke(
            UriTemplate = "postalCodeLookupJSON?postalcode={postalcode}&country={country}"
                + "&maxRows={maximumResults}&style={resultStyle}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        PostalCodeResults PostalCodeLookup(string postalcode, string country, int maximumResults,
            ResultStyle resultStyle, string userName);

        [OperationContract(Name = "postalCodeCountryInfoJSON")]
        [WebInvoke(
            UriTemplate = "postalCodeCountryInfoJSON?username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Results<Country> PostalCodeCountryInfo(string userName);

        [OperationContract(Name = "getJSON")]
        [WebInvoke(
            UriTemplate = "getJSON?geonameId={geoNameId}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Toponym Get(int geoNameId, string userName);

        [OperationContract(Name = "childrenJSON")]
        [WebInvoke(
            UriTemplate = "childrenJSON?geonameId={geoNameId}&style={resultStyle}&maxRows={maxRows}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Results<Toponym> Children(int geoNameId, string userName, ResultStyle resultStyle, int maxRows);

        [OperationContract(Name = "countryInfoJSON")]
        [WebInvoke(
            UriTemplate = "countryInfoJSON?username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Results<Country> Countries(string userName);

        [OperationContract(Name = "hierarchyJSON")]
        [WebInvoke(
            UriTemplate = "hierarchyJSON?geonameId={geoNameId}&style={resultStyle}&username={userName}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Hierarchy Hierarchy(int geoNameId, string userName, ResultStyle resultStyle);

    }
}

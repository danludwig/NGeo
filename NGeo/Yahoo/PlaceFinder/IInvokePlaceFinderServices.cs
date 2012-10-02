using System.ServiceModel;
using System.ServiceModel.Web;

namespace NGeo.Yahoo.PlaceFinder
{
    [ServiceContract]
    public interface IInvokePlaceFinderServices
    {
        [OperationContract(Name = "coordinates")]
        [WebGet(
            UriTemplate = "geocode?q={location}&locale={locale}&start={firstIndex}&count={maximumResults}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByCoordinates(string location,
            string locale, int firstIndex, int maximumResults,
            int offset, string flags, string gFlags, string appId);

        [OperationContract(Name = "coordinates2")]
        [WebGet(
            UriTemplate = "geocode?q={location}&locale={locale}&start={firstIndex}&count={maximumResults}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByCoordinates(string location,
            string locale, int firstIndex, int maximumResults,
            int offset, string flags, string gFlags, string appId);



        [OperationContract(Name = "freeform")]
        [WebGet(
            UriTemplate = "geocode?q={location}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByFreeformText(string location, string locale, int start, int count,
            int offset,  string flags, string gFlags, string appId);

        [OperationContract(Name = "freeform2")]
        [WebGet(
            UriTemplate = "geocode?q={location}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByFreeformText(string location, string locale, int start, int count,
            int offset, string flags, string gFlags, string appId);



        [OperationContract(Name = "name")]
        [WebGet(
            UriTemplate = "geocode?name={name}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByName(string name, string locale, int start, int count,
            int offset, string flags, string gFlags, string appId);

        [OperationContract(Name = "name2")]
        [WebGet(
            UriTemplate = "geocode?name={name}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByName(string name, string locale, int start, int count,
            int offset, string flags, string gFlags, string appId);



        [OperationContract(Name = "woeId")]
        [WebGet(
            UriTemplate = "geocode?woeid={woeId}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByWoeId(int woeId, string locale, int start, int count,
            int offset, string flags, string gFlags, string appId);

        [OperationContract(Name = "woeId2")]
        [WebGet(
            UriTemplate = "geocode?woeid={woeId}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByWoeId(int woeId, string locale, int start, int count,
            int offset, string flags, string gFlags, string appId);



        [OperationContract(Name = "multiline")]
        [WebGet(
            UriTemplate = "geocode?line1={line1}&line2={line2}&line3={line3}" +
                "&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByMultilineAddress(string line1, string line2, string line3,
            string locale, int start, int count, int offset, string flags, string gFlags,
            string appId);

        [OperationContract(Name = "multiline2")]
        [WebGet(
            UriTemplate = "geocode?line1={line1}&line2={line2}&line3={line3}" +
                "&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByMultilineAddress(string line1, string line2, string line3,
            string locale, int start, int count, int offset, string flags, string gFlags,
            string appId);



        [OperationContract(Name = "fullyParsed")]
        [WebGet(
            UriTemplate = "geocode?house={house}&street={street}&unittype={unitType}&unit={unit}" +
                "&xstreet={crossStreet}&postal={postal}&neighborhood={neighborhood}&city={city}&county={county}" +
                "&state={state}&country={country}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response FindOneByFullyParsedAddress(string house, string street, string unitType, string unit, string crossStreet,
            string postal, string neighborhood, string city, string county, string state, string country, string locale,
            int start, int count, int offset, string flags, string gFlags, string appId);

        [OperationContract(Name = "fullyParsed2")]
        [WebGet(
            UriTemplate = "geocode?house={house}&street={street}&unittype={unitType}&unit={unit}" +
                "&xstreet={crossStreet}&postal={postal}&neighborhood={neighborhood}&city={city}&county={county}" +
                "&state={state}&country={country}&locale={locale}&start={start}&count={count}" +
                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
        )]
        Response2 FindManyByFullyParsedAddress(string house, string street, string unitType, string unit, string crossStreet,
            string postal, string neighborhood, string city, string county, string state, string country, string locale,
            int start, int count, int offset, string flags, string gFlags, string appId);



    }
}

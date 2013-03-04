//using System.ServiceModel;
//using System.ServiceModel.Web;

//namespace NGeo.Yahoo.PlaceFinder
//{
//    [ServiceContract]
//    public interface IInvokePlaceFinderServices
//    {
//        [OperationContract(Name = "coordinates")]
//        [WebGet(
//            UriTemplate = "geocode?q={location}&locale={locale}&start={firstIndex}&count={maximumResults}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            RequestFormat = WebMessageFormat.Json,
//            ResponseFormat = WebMessageFormat.Json,
//            BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByCoordinates(string location,
//            string locale, int firstIndex, int maximumResults,
//            int offset, string flags, string gFlags, string appId);



//        [OperationContract(Name = "freeform")]
//        [WebGet(
//            UriTemplate = "geocode?q={location}&locale={locale}&start={start}&count={count}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByFreeformText(string location, string locale, int start, int count,
//            int offset,  string flags, string gFlags, string appId);



//        [OperationContract(Name = "name")]
//        [WebGet(
//            UriTemplate = "geocode?name={name}&locale={locale}&start={start}&count={count}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByName(string name, string locale, int start, int count,
//            int offset, string flags, string gFlags, string appId);



//        [OperationContract(Name = "woeId")]
//        [WebGet(
//            UriTemplate = "geocode?woeid={woeId}&locale={locale}&start={start}&count={count}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByWoeId(int woeId, string locale, int start, int count,
//            int offset, string flags, string gFlags, string appId);



//        [OperationContract(Name = "multiline")]
//        [WebGet(
//            UriTemplate = "geocode?line1={line1}&line2={line2}&line3={line3}" +
//                "&locale={locale}&start={start}&count={count}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            RequestFormat = WebMessageFormat.Json,
//            ResponseFormat = WebMessageFormat.Json,
//            BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByMultilineAddress(string line1, string line2, string line3,
//            string locale, int start, int count, int offset, string flags, string gFlags,
//            string appId);



//        [OperationContract(Name = "fullyParsed")]
//        [WebGet(
//            UriTemplate = "geocode?house={house}&street={street}&unittype={unitType}&unit={unit}" +
//                "&xstreet={crossStreet}&postal={postal}&neighborhood={neighborhood}&city={city}&county={county}" +
//                "&state={state}&country={country}&locale={locale}&start={start}&count={count}" +
//                "&offset={offset}&flags={flags}&gflags={gFlags}&appid={appId}",
//            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare
//        )]
//        Response FindByFullyParsedAddress(string house, string street, string unitType, string unit, string crossStreet,
//            string postal, string neighborhood, string city, string county, string state, string country, string locale,
//            int start, int count, int offset, string flags, string gFlags, string appId);



//    }
//}

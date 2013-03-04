namespace NGeo.Yahoo.PlaceFinder
{
    public sealed class PlaceFinderContainer : IContainPlaceFinder
    {
        private readonly string _consumerKey;
        private readonly string _consumerSecret;
        private readonly IConsumePlaceFinder _client;

        public PlaceFinderContainer(string consumerKey, string consumerSecret)
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
            _client = new PlaceFinderClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public ResultSet Find(PlaceByCoordinates request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }

        public ResultSet Find(PlaceByFreeformText request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }

        public ResultSet Find(PlaceByName request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }

        public ResultSet Find(PlaceByWoeId request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }

        public ResultSet Find(PlaceByMultilineAddress request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }

        public ResultSet Find(PlaceByFullyParsedAddress request)
        {
            return _client.Find(request, _consumerKey, _consumerSecret);
        }
    }
}

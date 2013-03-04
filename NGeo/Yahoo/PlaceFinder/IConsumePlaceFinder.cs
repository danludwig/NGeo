using System;

namespace NGeo.Yahoo.PlaceFinder
{
    public interface IConsumePlaceFinder : IDisposable
    {
        ResultSet Find(PlaceByCoordinates request, string consumerKey, string consumerSecret);
        ResultSet Find(PlaceByFreeformText request, string consumerKey, string consumerSecret);
        ResultSet Find(PlaceByName request, string consumerKey, string consumerSecret);
        ResultSet Find(PlaceByWoeId request, string consumerKey, string consumerSecret);
        ResultSet Find(PlaceByMultilineAddress request, string consumerKey, string consumerSecret);
        ResultSet Find(PlaceByFullyParsedAddress request, string consumerKey, string consumerSecret);
    }
}
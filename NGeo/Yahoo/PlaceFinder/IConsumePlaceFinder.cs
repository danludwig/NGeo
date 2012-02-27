using System;

namespace NGeo.Yahoo.PlaceFinder
{
    public interface IConsumePlaceFinder : IDisposable
    {
        ResultSet Find(PlaceByCoordinates request);
        ResultSet Find(PlaceByFreeformText request);
        ResultSet Find(PlaceByName request);
        ResultSet Find(PlaceByWoeId request);
        ResultSet Find(PlaceByMultilineAddress request);
        ResultSet Find(PlaceByFullyParsedAddress request);
    }
}
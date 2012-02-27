using System;
using System.ServiceModel;

namespace NGeo.Yahoo.PlaceFinder
{
    public sealed class PlaceFinderClient : ClientBase<IInvokePlaceFinderServices>, IConsumePlaceFinder
    {
        public ResultSet Find(PlaceByCoordinates request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByCoordinates(request.Location, request.Locale,
                request.Start, request.Count, request.Offset,
                request.GetFlagsAsString(), request.GetGFlagsAsString(),
                request.AppId);

            return response.ResultSet;
        }

        public ResultSet Find(PlaceByFreeformText request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByFreeformText(request.Location, request.Locale, 
                request.Start, request.Count, request.Offset, 
                request.GetFlagsAsString(), request.GetGFlagsAsString(), 
                request.AppId);

            return response.ResultSet;
        }

        public ResultSet Find(PlaceByName request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByName(request.Name, request.Locale, 
                request.Start, request.Count, request.Offset, 
                request.GetFlagsAsString(), request.GetGFlagsAsString(), 
                request.AppId);

            return response.ResultSet;
        }

        public ResultSet Find(PlaceByWoeId request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByWoeId(request.WoeId, request.Locale,
                request.Start, request.Count, request.Offset,
                request.GetFlagsAsString(), request.GetGFlagsAsString(),
                request.AppId);

            return response.ResultSet;
        }

        public ResultSet Find(PlaceByMultilineAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByMultilineAddress(request.Line1, 
                request.Line2, request.Line3, request.Locale,
                request.Start, request.Count, request.Offset,
                request.GetFlagsAsString(), request.GetGFlagsAsString(),
                request.AppId);

            return response.ResultSet;
        }

        public ResultSet Find(PlaceByFullyParsedAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = Channel.FindByFullyParsedAddress(request.House,
                request.Street, request.UnitType, request.Unit,
                request.CrossStreet, request.Postal, request.Neighborhood,
                request.City, request.County, request.StateOrProvince,
                request.Country, request.Locale, request.Start,
                request.Count, request.Offset, request.GetFlagsAsString(),
                request.GetGFlagsAsString(), request.AppId);

            return response.ResultSet;
        }

        private static void EnsureContractsAreSatisfied(PlaceBy request)
        {
            if (request.Flags.Contains(Flag.StreetDetail))
                request.Flags.Remove(Flag.StreetDetail);

            if (!request.Flags.Contains(Flag.Json))
                request.Flags.Add(Flag.Json);

            if (request.Flags.Contains(Flag.Php))
                request.Flags.Remove(Flag.Php);

            if (request is PlaceByCoordinates && !request.GFlags.Contains(GFlag.Reverse))
                request.GFlags.Add(GFlag.Reverse);
        }

    }
}

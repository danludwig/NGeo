using System;
using System.Net;
using System.ServiceModel;

namespace NGeo.Yahoo.PlaceFinder
{
    public sealed class PlaceFinderClient : ClientBase<IInvokePlaceFinderServices>, IConsumePlaceFinder
    {
        private const int RetryLimit = 5;

        public ResultSet Find(PlaceByCoordinates request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByCoordinates(request);

            return response.ResultSet;
        }

        private Response ChannelFindByCoordinates(PlaceByCoordinates request, int retry = 0)
        {
            try
            {
                return Channel.FindByCoordinates(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByCoordinates(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByCoordinates(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFreeformText request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByFreeformText(request);

            return response.ResultSet;
        }

        private Response ChannelFindByFreeformText(PlaceByFreeformText request, int retry = 0)
        {
            try
            {
                return Channel.FindByFreeformText(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByFreeformText(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByFreeformText(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByName request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByName(request);

            return response.ResultSet;
        }

        private Response ChannelFindByName(PlaceByName request, int retry = 0)
        {
            try
            {
                return Channel.FindByName(request.Name, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByName(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByName(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByWoeId request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByWoeId(request);

            return response.ResultSet;
        }

        private Response ChannelFindByWoeId(PlaceByWoeId request, int retry = 0)
        {
            try
            {
                return Channel.FindByWoeId(request.WoeId, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByWoeId(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByWoeId(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByMultilineAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByMultilineAddress(request);

            return response.ResultSet;
        }

        private Response ChannelFindByMultilineAddress(PlaceByMultilineAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindByMultilineAddress(request.Line1,
                    request.Line2, request.Line3, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByMultilineAddress(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByMultilineAddress(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFullyParsedAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindByFullyParsedAddress(request);

            return response.ResultSet;
        }

        private Response ChannelFindByFullyParsedAddress(PlaceByFullyParsedAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindByFullyParsedAddress(request.House,
                    request.Street, request.UnitType, request.Unit,
                    request.CrossStreet, request.Postal, request.Neighborhood,
                    request.City, request.County, request.StateOrProvince,
                    request.Country, request.Locale, request.Start,
                    request.Count, request.Offset, request.GetFlagsAsString(),
                    request.GetGFlagsAsString(), request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindByFullyParsedAddress(request, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return ChannelFindByFullyParsedAddress(request, ++retry);
                throw;
            }
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

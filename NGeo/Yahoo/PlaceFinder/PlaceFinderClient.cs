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

            var response = ChannelFindOneByCoordinates(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByCoordinates(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByCoordinates(PlaceByCoordinates request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByCoordinates(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindOneByCoordinates(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByCoordinates(PlaceByCoordinates request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByCoordinates(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindManyByCoordinates(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFreeformText request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindOneByFreeformText(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByFreeformText(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByFreeformText(PlaceByFreeformText request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByFreeformText(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindOneByFreeformText(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByFreeformText(PlaceByFreeformText request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByFreeformText(request.Location, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindManyByFreeformText(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByName request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindOneByName(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByName(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByName(PlaceByName request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByName(request.Name, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindOneByName(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByName(PlaceByName request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByName(request.Name, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindManyByName(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByWoeId request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindOneByWoeId(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByWoeId(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByWoeId(PlaceByWoeId request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByWoeId(request.WoeId, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindOneByWoeId(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByWoeId(PlaceByWoeId request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByWoeId(request.WoeId, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindManyByWoeId(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByMultilineAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindOneByMultilineAddress(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByMultilineAddress(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByMultilineAddress(PlaceByMultilineAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByMultilineAddress(request.Line1,
                    request.Line2, request.Line3, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindOneByMultilineAddress(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByMultilineAddress(PlaceByMultilineAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByMultilineAddress(request.Line1,
                    request.Line2, request.Line3, request.Locale,
                    request.Start, request.Count, request.Offset,
                    request.GetFlagsAsString(), request.GetGFlagsAsString(),
                    request.AppId);
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return ChannelFindManyByMultilineAddress(request, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFullyParsedAddress request)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = ChannelFindOneByFullyParsedAddress(request);
            if (response.ResultSet.Found != 1)
            {
                var response2 = ChannelFindManyByFullyParsedAddress(request);
                response = new Response(response2);
            }

            return response.ResultSet;
        }

        private Response ChannelFindOneByFullyParsedAddress(PlaceByFullyParsedAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindOneByFullyParsedAddress(request.House,
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
                    return ChannelFindOneByFullyParsedAddress(request, ++retry);
                throw;
            }
        }

        private Response2 ChannelFindManyByFullyParsedAddress(PlaceByFullyParsedAddress request, int retry = 0)
        {
            try
            {
                return Channel.FindManyByFullyParsedAddress(request.House,
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
                    return ChannelFindManyByFullyParsedAddress(request, ++retry);
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

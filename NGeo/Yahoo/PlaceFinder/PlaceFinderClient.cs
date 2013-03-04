using System;
using System.Net;
using System.ServiceModel;
using Newtonsoft.Json;

namespace NGeo.Yahoo.PlaceFinder
{
    public sealed class PlaceFinderClient : IConsumePlaceFinder
    {
        private const int RetryLimit = 5;

        public ResultSet Find(PlaceByCoordinates request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByCoordinates request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFreeformText request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByFreeformText request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByName request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByName request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByWoeId request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByWoeId request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByMultilineAddress request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByMultilineAddress request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
        }

        public ResultSet Find(PlaceByFullyParsedAddress request, string consumerKey, string consumerSecret)
        {
            if (request == null) throw new ArgumentNullException("request");
            EnsureContractsAreSatisfied(request);

            var response = OAuthFind(request, consumerKey, consumerSecret);
            return response.PlaceFinder;
        }

        private static BossResponse OAuthFind(PlaceByFullyParsedAddress request, string consumerKey, string consumerSecret, int retry = 0)
        {
            try
            {
                using (var oAuth = new OAuthClient())
                {
                    var json = oAuth.Get(request.GetUri(), consumerKey, consumerSecret);
                    var bossContainer = JsonConvert.DeserializeObject<BossContainer>(json);
                    if (bossContainer != null) return bossContainer.BossResponse;
                    throw new InvalidOperationException("Unable to parse BOSS GEO Response. Raw JSON:\r\n" + json);
                }
            }
            catch (ProtocolException ex)
            {
                if (retry < RetryLimit && ex.InnerException is WebException)
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
                throw;
            }
            catch (CommunicationException ex)
            {
                if (retry < RetryLimit && ex.Message == "Server Error")
                    return OAuthFind(request, consumerKey, consumerSecret, ++retry);
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

        public void Dispose()
        {
        }
    }
}

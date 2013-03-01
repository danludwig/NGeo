using System;
using System.Collections.Generic;

namespace NGeo.Yahoo.GeoPlanet.Json
{
    internal static class JsonConverter
    {
        internal static Place ToPlace(this JsonPlace jsonPlace)
        {
            if (jsonPlace == null) throw new ArgumentNullException("jsonPlace");

            var place = new Place
            {
                WoeId = jsonPlace.WoeId,
                Name = jsonPlace.Name,
                Language = jsonPlace.Language,
                Uri = jsonPlace.Uri,
                Center = jsonPlace.Center,
                BoundingBox = jsonPlace.BoundingBox,
                AreaRank = jsonPlace.AreaRank,
                PopulationRank = jsonPlace.PopulationRank,
                Postal = jsonPlace.Postal,
                Type = (jsonPlace.Type != null || !string.IsNullOrWhiteSpace(jsonPlace.TypeName)) ? new PlaceType
                {
                    Name = jsonPlace.TypeName,
                    Code = (jsonPlace.Type != null) ? jsonPlace.Type.Code : default(int),
                } : null,
                Country = (jsonPlace.Country != null || !string.IsNullOrWhiteSpace(jsonPlace.CountryName)) ? new Admin
                {
                    Name = jsonPlace.CountryName,
                    Code = (jsonPlace.Country != null) ? jsonPlace.Country.Code : null,
                    Type = (jsonPlace.Country != null) ? jsonPlace.Country.Type : null,
                } : null,
                Admin1 = (jsonPlace.Admin1 != null || !string.IsNullOrWhiteSpace(jsonPlace.Admin1Name)) ? new Admin
                {
                    Name = jsonPlace.Admin1Name,
                    Code = (jsonPlace.Admin1 != null) ? jsonPlace.Admin1.Code : null,
                    Type = (jsonPlace.Admin1 != null) ? jsonPlace.Admin1.Type : null,
                } : null,
                Admin2 = (jsonPlace.Admin2 != null || !string.IsNullOrWhiteSpace(jsonPlace.Admin2Name)) ? new Admin
                {
                    Name = jsonPlace.Admin2Name,
                    Code = (jsonPlace.Admin2 != null) ? jsonPlace.Admin2.Code : null,
                    Type = (jsonPlace.Admin2 != null) ? jsonPlace.Admin2.Type : null,
                } : null,
                Admin3 = (jsonPlace.Admin3 != null || !string.IsNullOrWhiteSpace(jsonPlace.Admin3Name)) ? new Admin
                {
                    Name = jsonPlace.Admin3Name,
                    Code = (jsonPlace.Admin3 != null) ? jsonPlace.Admin3.Code : null,
                    Type = (jsonPlace.Admin3 != null) ? jsonPlace.Admin3.Type : null,
                } : null,
                Locality1 = (jsonPlace.Locality1 != null || !string.IsNullOrWhiteSpace(jsonPlace.Locality1Name)) ? new Locality
                {
                    Name = jsonPlace.Locality1Name,
                    Type = (jsonPlace.Locality1 != null) ? jsonPlace.Locality1.Type : null,
                } : null,
                Locality2 = (jsonPlace.Locality2 != null || !string.IsNullOrWhiteSpace(jsonPlace.Locality2Name)) ? new Locality
                {
                    Name = jsonPlace.Locality2Name,
                    Type = (jsonPlace.Locality2 != null) ? jsonPlace.Locality2.Type : null,
                } : null,
            };

            return place;
        }

        internal static List<Place> ToPlaces(this List<JsonPlace> jsonPlaces)
        {
            if (jsonPlaces == null) throw new ArgumentNullException("jsonPlaces");

            var places = new List<Place>();
            jsonPlaces.ForEach(jsonPlace => places.Add(jsonPlace.ToPlace()));
            return places;
        }

        private static PlaceType ToPlaceType(this JsonPlaceType jsonPlaceType)
        {
            if (jsonPlaceType == null) throw new ArgumentNullException("jsonPlaceType");

            var placeType = new PlaceType
            {
                Name = jsonPlaceType.Name,
                Language = jsonPlaceType.Language,
                Uri = jsonPlaceType.Uri,
                Description = jsonPlaceType.Description,
                Code = (jsonPlaceType.JsonAttributes != null) ? jsonPlaceType.JsonAttributes.Code : default(int),
            };

            return placeType;
        }

        internal static List<PlaceType> ToPlaceTypes(this List<JsonPlaceType> jsonPlaceTypes)
        {
            if (jsonPlaceTypes == null) throw new ArgumentNullException("jsonPlaceTypes");

            var placeTypes = new List<PlaceType>();
            jsonPlaceTypes.ForEach(jsonPlaceType => placeTypes.Add(jsonPlaceType.ToPlaceType()));

            return placeTypes;
        }

    }
}

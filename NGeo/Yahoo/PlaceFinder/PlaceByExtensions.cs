
namespace NGeo.Yahoo.PlaceFinder
{
    public static class PlaceByExtensions
    {
        /// <summary>
        /// Only return coordinate data and match quality elements; do not return address data elements.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="coordinateDataOnly">Whether or not to only include coordinate data. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T ReturnCoordinateDataOnly<T>(this T placeBy, bool coordinateDataOnly = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, coordinateDataOnly, Flag.CoordinateDataOnly);
        }

        /// <summary>
        /// Do not return woeid element. This impacts the radius output.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="exclude">Whether to exclude WOE ID from results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T ExcludeWoeId<T>(this T placeBy, bool exclude = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, exclude, Flag.NoWoeId);
        }

        /// <summary>
        /// Return global area elements instead of US-specific elements.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="returnGlobalInsteadOfUsElements">Whether to return global area elements 
        /// instead of US-specific elements in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T ReturnGlobalElements<T>(this T placeBy, bool returnGlobalInsteadOfUsElements = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, returnGlobalInsteadOfUsElements, Flag.Global);
        }

        /// <summary>
        /// Return nearest commercial airport code element for each result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to include airport code in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeAirportCode<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, include, Flag.Airport);
        }

        /// <summary>
        /// Return telephone area code element for each result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to include telephone area code in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeTelephoneAreaCode<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, include, Flag.TelephoneAreaCode);
        }

        /// <summary>
        /// Return timezone information element for each result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to include time zone in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeTimeZone<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, include, Flag.TimeZone);
        }

        /// <summary>
        /// Return bounding box element for each area result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to include bounding box in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeBoundingBox<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveFlag(placeBy, include, Flag.BoundingBox);
        }

        /// <summary>
        /// Return neighborhood names for each result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to include neighborhood names in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeNeighborhoods<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveGFlag(placeBy, include, GFlag.Neighborhoods);
        }

        /// <summary>
        /// Look up cross streets for each result.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="include">Whether to look up cross streets in results. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T IncludeCrossStreets<T>(this T placeBy, bool include = true) where T : PlaceBy
        {
            return AddOrRemoveGFlag(placeBy, include, GFlag.CrossStreets);
        }

        /// <summary>
        /// Limit results to the locale country.
        /// </summary>
        /// <typeparam name="T">A concrete instance of PlaceBy.</typeparam>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="limitToLocaleCountry">Whether to limit results to the locale country. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static T LimitResultsToLocaleCountry<T>(this T placeBy, bool limitToLocaleCountry = true) where T : PlaceBy
        {
            return AddOrRemoveGFlag(placeBy, limitToLocaleCountry, GFlag.LimitToLocaleCountry);
        }

        /// <summary>
        /// Quick mode, enable exact matches only for free-form input.
        /// </summary>
        /// <param name="placeBy">The concrete instance of PlaceBy.</param>
        /// <param name="enableQuickMode">Whether to enable exact matches only for free-form input. Default is true.</param>
        /// <returns>The same instance of PlaceBy that this method was invoked on, for method chaining.</returns>
        public static PlaceByFreeformText QuickMode(this PlaceByFreeformText placeBy, bool enableQuickMode = true)
        {
            return AddOrRemoveGFlag(placeBy, enableQuickMode, GFlag.QuickMode);
        }

        private static T AddOrRemoveFlag<T>(this T placeBy, bool addOrNot, Flag flag) where T : PlaceBy
        {
            if (addOrNot && !placeBy.Flags.Contains(flag))
                placeBy.Flags.Add(flag);

            else if (!addOrNot)
            {
                if (placeBy.Flags.Contains(flag))
                    placeBy.Flags.Remove(flag);
            }

            return placeBy;
        }

        private static T AddOrRemoveGFlag<T>(this T placeBy, bool addOrNot, GFlag gFlag) where T : PlaceBy
        {
            if (addOrNot && !placeBy.GFlags.Contains(gFlag))
                placeBy.GFlags.Add(gFlag);

            else if (!addOrNot)
            {
                if (placeBy.GFlags.Contains(gFlag))
                    placeBy.GFlags.Remove(gFlag);
            }

            return placeBy;
        }

    }
}
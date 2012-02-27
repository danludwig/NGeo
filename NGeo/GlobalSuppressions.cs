using System.Diagnostics.CodeAnalysis;

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", 
    Justification = "Test project cannot be strongly-named.")]

[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.Json.JsonConverter.#ToPlace(NGeo.Yahoo.GeoPlanet.Json.JsonPlace)",
    Justification = "Method is easy to understand, test, and maintain")]

#region CA1026 Default Parameter Values Suppressions

[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.GeoNamesClient.#Children(System.Int32,System.String,NGeo.GeoNames.ResultStyle,System.Int32)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.GeoNamesClient.#Countries(System.String,NGeo.GeoNames.ResultStyle)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.GeoNamesClient.#Get(System.Int32,System.String,NGeo.GeoNames.ResultStyle)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.IConsumeGeoNames.#Children(System.Int32,System.String,NGeo.GeoNames.ResultStyle,System.Int32)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.IConsumeGeoNames.#Countries(System.String,NGeo.GeoNames.ResultStyle)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.IConsumeGeoNames.#Get(System.Int32,System.String,NGeo.GeoNames.ResultStyle)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Ancestors(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Countries(System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Parent(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Place(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Types(System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Ancestors(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Countries(System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Parent(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Place(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Types(System.String,NGeo.Yahoo.GeoPlanet.RequestView)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#ExcludeWoeId`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeAirportCode`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeBoundingBox`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeCrossStreets`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeNeighborhoods`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeTelephoneAreaCode`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#IncludeTimeZone`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#LimitResultsToLocaleCountry`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#QuickMode(NGeo.Yahoo.PlaceFinder.PlaceByFreeformText,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#ReturnCoordinateDataOnly`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByExtensions.#ReturnGlobalElements`1(!!0,System.Boolean)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.PlaceByMultilineAddress.#.ctor(System.String,System.String,System.String)", 
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Type(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Type(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#BelongTos(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#BelongTos(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.GeoNamesClient.#Hierarchy(System.Int32,System.String,NGeo.GeoNames.ResultStyle)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.GeoNames.IConsumeGeoNames.#Hierarchy(System.Int32,System.String,NGeo.GeoNames.ResultStyle)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Continents(System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Continents(System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#States(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#States(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Level1Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Level1Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Counties(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.GeoPlanetClient.#Level2Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Counties(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Level2Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Compiler does not ignore default parameter values.")]

#endregion
#region CA1702 Compound Casing Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", 
    MessageId = "nameSpace", Scope = "member", 
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Concordance(NGeo.Yahoo.GeoPlanet.ConcordanceNamespace,System.Int32,System.String)",
    Justification = "Discrete casing would make term a keyword.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", 
    MessageId = "nameSpace", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Concordance(NGeo.Yahoo.GeoPlanet.ConcordanceNamespace,System.String,System.String)",
    Justification = "Discrete casing would make term a keyword.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", 
    MessageId = "nameSpace", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IInvokeGeoPlanetServices.#Concordance(System.String,System.String,System.String)",
    Justification = "Discrete casing would make term a keyword.")]

#endregion
#region CA1704 Spelling Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Fips", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceNamespace.#Fips10", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Fips", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceResponse.#Fips10", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Fips", Scope = "member",
    Target = "NGeo.GeoNames.Country.#FipsCode", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Iana", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceNamespace.#IanaTld", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Iana", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceResponse.#IanaTld", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Tld", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceNamespace.#IanaTld", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Tld", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.ConcordanceResponse.#IanaTld", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Toponym", Scope = "member",
    Target = "NGeo.GeoNames.Toponym.#ToponymName", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Toponym", Scope = "type",
    Target = "NGeo.GeoNames.Toponym", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByCoordinates(System.String,System.String,System.Int32," +
        "System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFreeformText(System.String,System.String,System.Int32," +
        "System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFullyParsedAddress(System.String,System.String," + 
        "System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String," +        
        "System.String,System.String,System.Int32,System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByMultilineAddress(System.String,System.String,System.String,System.String," +
        "System.Int32,System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByName(System.String,System.String,System.Int32,System.Int32," + 
        "System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "g", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByWoeId(System.Int32,System.String,System.Int32,System.Int32," + 
        "System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
    MessageId = "Tos", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#BelongTos(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
    MessageId = "Tos", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IInvokeGeoPlanetServices.#BelongTos(System.String,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Admins", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Level1Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", 
    MessageId = "Admins", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Level2Admins(System.Int32,System.String,NGeo.Yahoo.GeoPlanet.RequestView)",
    Justification = "Naming matches domain language.")]

#endregion
#region CA1709 Casing Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", 
    MessageId = "Km", Scope = "member",
    Target = "NGeo.GeoNames.Country.#AreaInSqKm", 
    Justification = "Casing matches ReSharper casing rules.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", 
    MessageId = "Km", Scope = "member",
    Target = "NGeo.GeoNames.NearbyPlaceNameFinder.#RadiusInKm", 
    Justification = "Casing matches ReSharper casing rules.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", 
    MessageId = "Sq", Scope = "member",
    Target = "NGeo.GeoNames.Country.#AreaInSqKm", 
    Justification = "Casing matches ReSharper casing rules.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", 
    MessageId = "Km", Scope = "member",
    Target = "NGeo.GeoNames.IInvokeGeoNamesServices.#FindNearbyPlaceName(System.Double,System.Double,System.String,System.Double,System.Int32," +
        "NGeo.GeoNames.ResultStyle,System.String)", 
    Justification = "Casing matches ReSharper casing rules.")]

#endregion
#region CA1710 Type Suffix Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NGeo.GeoNames.Hierarchy", 
    Justification = "Suggested suffix clutters domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NGeo.Yahoo.GeoPlanet.Places", 
    Justification = "Suggested suffix clutters domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NGeo.Yahoo.GeoPlanet.PlaceTypes", 
    Justification = "Suggested suffix clutters domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NGeo.GeoNames.Results`1", 
    Justification = "Suggested suffix clutters domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type",
    Target = "NGeo.Yahoo.PlaceFinder.ResultSet", 
    Justification = "Suggested suffix clutters domain language.")]

#endregion
#region CA1716 Keyword Match Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", 
    MessageId = "Namespace", Scope = "member", 
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Concordance(NGeo.Yahoo.GeoPlanet.ConcordanceNamespace,System.Int32,System.String)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", 
    MessageId = "Namespace", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IConsumeGeoPlanet.#Concordance(NGeo.Yahoo.GeoPlanet.ConcordanceNamespace,System.String,System.String)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", 
    MessageId = "Namespace", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.IInvokeGeoPlanetServices.#Concordance(System.String,System.String,System.String)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", 
    MessageId = "Get", Scope = "member",
    Target = "NGeo.GeoNames.IConsumeGeoNames.#Get(System.Int32,System.String)",
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", 
    MessageId = "Get", Scope = "member",
    Target = "NGeo.GeoNames.IInvokeGeoNamesServices.#Get(System.Int32,System.String)",
    Justification = "Naming matches domain language.")]

#endregion
#region CA1721 Confusion Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.Admin.#Type", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.Locality.#Type", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
    Target = "NGeo.Yahoo.GeoPlanet.Place.#Type", 
    Justification = "Naming matches domain language.")]

#endregion
#region CA1726 Preferred Name Suppressions

[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByCoordinates(System.String,System.String,System.Int32" +
        ",System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByCoordinates(System.String,System.String,System.Int32,System.Int32" +
        ",System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFreeformText(System.String,System.String,System.Int32," +
        "System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFreeformText(System.String,System.String,System.Int32,System.Int32" +
        ",System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFullyParsedAddress(System.String,System.String,System.String,System.String," +
        "System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32," +
        "System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByFullyParsedAddress(System.String,System.String,System.String,System.String" +
        ",System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Int32," +
        "System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByMultilineAddress(System.String,System.String,System.String" +
        ",System.String,System.Int32,System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByMultilineAddress(System.String,System.String,System.String,System.String" +
        ",System.Int32,System.Int32,System.Int32,System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByName(System.String,System.String,System.Int32,System.Int32,System.Int32," +
        "System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByName(System.String,System.String,System.Int32,System.Int32,System.Int32," +
        "System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByWoeId(System.Int32,System.String,System.Int32,System.Int32,System.Int32,"
        + "System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", 
    MessageId = "Flags", Scope = "member",
    Target = "NGeo.Yahoo.PlaceFinder.IInvokePlaceFinderServices.#FindByWoeId(System.Int32,System.String,System.Int32,System.Int32,System.Int32," +
        "System.String,System.String,System.String)", 
    Justification = "Naming matches domain language.")]

#endregion

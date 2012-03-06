# NGeo
NGeo makes it easier for users of geographic data to invoke GeoNames and Yahoo! GeoPlanet / PlaceFinder services. You'll no longer have to write your own GeoNames, GeoPlanet, or PlaceFinder clients. It's developed in ASP.NET 4.0, and uses WCF ServiceModel libraries to deserialize JSON data into Plain Old C# Objects.

## License
This software is subject to the terms of the [Microsoft Public License (Ms-PL)](http://www.opensource.org/licenses/MS-PL).

## How can I use it?
    using (var geoNamesClient = new NGeo.GeoNames.GeoNamesClient())
    {
        var toponym = geoNamesClient.Get(6295630, "demo"); // replace with your own username
        // do something with the data
    }

## Why should I use it?
There are at least 2 other GeoNames clients that I'm aware of, and they are listed on the [GeoNames Client Libraries page](http://www.geonames.org/export/client-libraries.html). This project is very much like the [.NET WCF project written by Baretta2 / Myren](http://www.codeproject.com/Articles/30627/GeoNames-NET-WCF-Client). I started modifying the Myren.GeoNames.Client project source code because my organization bought premium GeoNames credits, and we needed to invoke a different service URL. Also, since Baretta2's project was published, GeoNames has started requiring a username parameter to be passed to each web service invocation.

But that wasn't enough. We also needed a client for the [Yahoo! GeoPlanet API](http://developer.yahoo.com/geo/geoplanet/data/), and to my knowledge, there is not one of these written in .NET. So we rolled our own.

But that still wasn't enough. I also wanted this code to be available as a [NuGet package](http://nuget.org/packages/NGeo), so that I could use it in multiple projects.

So if you want a NuGet package that can give your app a client for GeoNames, Yahoo! GeoPlanet, and Yahoo! PlaceFinder services, this is the only one I'm aware of.

## What if I don't like it?
So far, I've only built out clients for the services I use in my projects. If you would like to contribute to this project instead of building your own, feel free to fork and send me a pull request.

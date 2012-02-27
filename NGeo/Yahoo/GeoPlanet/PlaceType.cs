using System;

namespace NGeo.Yahoo.GeoPlanet
{
    public class PlaceType
    {
        public string Name { get; internal set; }
        public string Language { get; internal set; }
        public Uri Uri { get; internal set; }
        public string Description { get; internal set; }
        public int Code { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
using System;
using System.Globalization;

namespace NGeo.Yahoo.GeoPlanet
{
    public class Place
    {
        public int WoeId { get; internal set; }

        public string Name { get; internal set; }


        public string Language { get; internal set; }
        public Uri Uri { get; internal set; }

        public Point Center { get; internal set; }

        public BoundingBox BoundingBox { get; internal set; }

        public int AreaRank { get; internal set; }

        public int PopulationRank { get; internal set; }

        private string _postal;
        public string Postal
        {
            get { return _postal; }
            internal set { _postal = value.ToNullIfEmptyOrWhiteSpace(); }
        }

        public PlaceType Type { get; internal set; }

        public Admin Country { get; internal set; }

        public Admin Admin1 { get; internal set; }

        public Admin Admin2 { get; internal set; }

        public Admin Admin3 { get; internal set; }

        public Locality Locality1 { get; internal set; }

        public Locality Locality2 { get; internal set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", Name, Type.Name);
        }

    }
}
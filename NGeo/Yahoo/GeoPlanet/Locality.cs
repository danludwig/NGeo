namespace NGeo.Yahoo.GeoPlanet
{
    public class Locality
    {
        public string Name { get; internal set; }
        public string Type { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
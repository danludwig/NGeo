namespace NGeo.Yahoo.GeoPlanet
{
    public class Admin
    {
        private string _code;
        public string Code
        {
            get { return _code; }
            internal set { _code = value.ToNullIfEmptyOrWhiteSpace(); }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            internal set { _type = value.ToNullIfEmptyOrWhiteSpace(); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            internal set { _name = value.ToNullIfEmptyOrWhiteSpace(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
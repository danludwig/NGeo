using System.Globalization;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public class AlternateName
    {
        [DataMember(Name = "name")]
        public string Name { get; internal set; }

        [DataMember(Name = "lang")]
        public string Language { get; internal set; }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}:{1}", Language, Name);
        }
    }
}

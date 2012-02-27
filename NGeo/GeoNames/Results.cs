using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class Results<T> : IEnumerable<T>
    {
        [DataMember(Name = "geonames")]
        internal List<T> Items { get; set; }

        [DataMember(Name = "totalResultsCount")]
        public int? Size { get; internal set; }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

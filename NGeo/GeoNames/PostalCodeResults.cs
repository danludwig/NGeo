using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class PostalCodeResults : IEnumerable<Code>
    {
        [DataMember(Name = "postalcodes")]
        internal List<Code> Items { get; set; }

        public IEnumerator<Code> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

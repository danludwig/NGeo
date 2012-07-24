using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class PostalCodeResults : IEnumerable<PostalCode>
    {
        [DataMember(Name = "postalcodes")]
        internal List<PostalCode> Items { get; set; }

        public IEnumerator<PostalCode> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

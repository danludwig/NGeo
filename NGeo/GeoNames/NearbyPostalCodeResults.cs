using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class NearbyPostalCodeResults : IEnumerable<NearbyPostalCode>
    {
        [DataMember(Name = "postalCodes")]
        internal List<NearbyPostalCode> Items { get; set; }

        public IEnumerator<NearbyPostalCode> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

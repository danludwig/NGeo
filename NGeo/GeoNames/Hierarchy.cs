using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace NGeo.GeoNames
{
    [DataContract]
    public sealed class Hierarchy : IEnumerable<Toponym>
    {
        [DataMember(Name = "geonames")]
        internal List<Toponym> ItemsList
        {
            get { return _itemsList; }
            set
            {
                _itemsList = value;
                Items = new ReadOnlyCollection<Toponym>(value);
            }
        }
        private List<Toponym> _itemsList;

        public ReadOnlyCollection<Toponym> Items { get; private set; }

        public IEnumerator<Toponym> GetEnumerator()
        {
            return ItemsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

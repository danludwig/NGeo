using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using NGeo.Yahoo.GeoPlanet.Json;

namespace NGeo.Yahoo.GeoPlanet
{
    [DataContract]
    public class Places : IEnumerable<Place>
    {
        [DataMember(Name = "start")]
        public int Start { get; internal set; }

        [DataMember(Name = "count")]
        public int Count { get; internal set; }

        [DataMember(Name = "total")]
        public int Total { get; internal set; }

        [DataMember(Name = "place")]
        internal List<JsonPlace> JsonItems { get; set; }

        public ReadOnlyCollection<Place> Items { get; internal set; }

        public IEnumerator<Place> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
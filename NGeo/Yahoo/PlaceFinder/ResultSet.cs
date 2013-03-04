using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace NGeo.Yahoo.PlaceFinder
{
    [JsonObject]
    public class ResultSet : IEnumerable<Result>
    {
        public int Start { get; set; }
        public int Count { get; set; }
        public string Request { get; set; }

        public Result[] Results { get; set; }

        public IEnumerator<Result> GetEnumerator()
        {
            return Results.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
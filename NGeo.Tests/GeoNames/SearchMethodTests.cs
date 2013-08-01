using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace NGeo.GeoNames
{
    [TestClass]
    public class GeoNames_SearchMethod_Tests
    {
        [TestMethod]
        public void GeoNames_Search_SearchByIataCodeFRA()
        {

            using (var client = new GeoNamesClient())
            {

                var searchOptions = new SearchOptions(SearchType.Name, "FRA");
                searchOptions.UserName = "nabortu";
                searchOptions.Language = "ru";
                searchOptions.SearchLang = "iata";

                var results = client.Search(searchOptions);

                results[0].GeoNameId.ShouldEqual(2925533);

            }
        }

        [TestMethod]
        public void GeoNames_Search_SearchByNameFRA()
        {

            using (var client = new GeoNamesClient())
            {

                var searchOptions = new SearchOptions(SearchType.Name, "FRA");
                searchOptions.UserName = "nabortu";
                searchOptions.Language = "ru";

                var results = client.Search(searchOptions);

                results[0].GeoNameId.ShouldEqual(5957210);

            }
        }
    }
}

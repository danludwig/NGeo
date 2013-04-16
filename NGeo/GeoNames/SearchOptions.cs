using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGeo.GeoNames
{
    public class SearchOptions
    {
        /// <summary>
        /// Default property values are: Language = "local", MaxRows = 100, Style = ResultStyle.Full.
        /// </summary>
        public SearchOptions(SearchType searchType, string text)
        {
            Language = "local";
            MaxRows = 100;
            Style = ResultStyle.Medium;
            SearchType = searchType;
            Text = text;
        }

        /// <summary>
        /// The type of search to execute, either a query against attribute, query against name, or query against exact name.
        /// </summary>
        public SearchType SearchType { get; set; }

        /// <summary>
        /// The text to search for, using either query, name, or name equals.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// GeoNames services require a user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Language of returned 'name' element (the pseudo language code 'local' will return it in local language).
        /// Default value is 'local'.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Index to return when paginating results. Default value is 0.
        /// </summary>
        public int StartRow { get; set; }

        /// <summary>
        /// Don't return any more than this number of results. Default value is 100.
        /// </summary>
        public int MaxRows { get; set; }

        /// <summary>
        /// Amount of detail returned by the GeoNames service. Default value is Full.
        /// </summary>
        public ResultStyle Style { get; set; }
    }
}

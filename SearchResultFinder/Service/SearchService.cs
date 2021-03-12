using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchResultFinder.Service
{
    public class GoogleSearchService : ISearchService
    {
        public string Search(string url, string keywords)
        {
            if (string.IsNullOrEmpty(url)) return "0";
            if (string.IsNullOrEmpty(keywords)) return "0";

            var googleSearchUrl = "https://infotrack-tests.infotrack.com.au/Google/Page01.html"; //$"https://www.google.com/search?num=100&q={keywords}";
            return SearchHelper.GetSearchResults(url, googleSearchUrl);
        }
    }

    public class BingSearchService : ISearchService
    {
        public string Search(string url, string keywords)
        {
            if (string.IsNullOrEmpty(url)) return "0";
            if (string.IsNullOrEmpty(keywords)) return "0";

            var bingSearchUrl = "https://www.bing.com/search?num=50&q={keywords}";
            return SearchHelper.GetSearchResults(url, bingSearchUrl);
        }
    }
}

using SearchResultFinder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchResultFinder
{
    public interface ISearchFacade
    {
        string GetSearchResults(string url, string keywords, string searchEngine = "Google");
    }
    public class SearchFacade : ISearchFacade
    {
        public string GetSearchResults(string url, string keywords, string searchEngine = "Google")
        {
            var searchResult = string.Empty;

            if (searchEngine.Equals("Google"))
            {
                var googleSearchService = new GoogleSearchService();
                searchResult = googleSearchService.Search(url, keywords);
            }
            else if (searchEngine.Equals("Bing"))
            {
                var bingSearchService = new BingSearchService();
                searchResult = bingSearchService.Search(url, keywords);
            }


            return searchResult;
        }
    }
}

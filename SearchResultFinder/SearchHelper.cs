using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;


namespace SearchResultFinder
{
    public static class SearchHelper
    {
        public static string GetSearchResults(string searchText, string searchEngineUrl)
        {
            WebClient wc = new WebClient();

            string htmlText = wc.DownloadString(searchEngineUrl);

            Regex pattern = new Regex(@"<cite[^>]*>(.*?)</cite>", RegexOptions.Singleline);
            MatchCollection match = pattern.Matches(htmlText);

            int location = 1;

            string searchPattern = String.Format(@"<cite[^>]*>(.*?){0}(.*?)</cite>", searchText);
            var searchResults = new List<string>();
            foreach (Match m in match)
            {
                bool isMatch = Regex.IsMatch(m.ToString(), searchPattern);

                if (isMatch)
                {
                    //result = String.Concat(result, location, ", ");
                    searchResults.Add(location.ToString());
                }

                location++;
            }

            return (searchResults.Any()) ? string.Join(",", searchResults) : "0";

        }
    }
}

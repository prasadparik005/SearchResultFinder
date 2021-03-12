using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchResultFinder.Models
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            Url = string.Empty;
            Keywords = string.Empty;
        }
        public string Url { get; set; }
        public string Keywords { get; set; }
        public string SearchEngine { get; set; }
    }
}
